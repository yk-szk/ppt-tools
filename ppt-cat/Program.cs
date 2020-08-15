using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Core = Microsoft.Office.Core;

namespace ppt_cat
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] filenames;
            if (args.Length == 0)
            {
                var dialog = new System.Windows.Forms.OpenFileDialog();
                dialog.Filter = "PowerPoint |*.pptx;*.ppt|All|*.*";
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filenames = dialog.FileNames;
                }
                else
                {
                    return;
                }
            }
            else
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(args[0], System.Text.Encoding.GetEncoding("shift_jis"));
                var list_dir = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(args[0]));
                string line = "";
                var fns = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    if (System.IO.Path.IsPathRooted(line))
                    {
                        fns.Add(line);
                    }
                    else
                    {
                        fns.Add(list_dir + "\\" + line);
                    }
                }
                filenames = fns.ToArray();
            }
            if (filenames.Length == 0)
            {
                return;
            }
            try
            {
                Console.WriteLine(filenames[0]);
                var app = new PowerPoint.Application();
                var ppt = app.Presentations.Open(System.IO.Path.GetFullPath(filenames[0]), Core.MsoTriState.msoTrue, Core.MsoTriState.msoFalse, Core.MsoTriState.msoFalse);
                for (int i = 1; i < filenames.Length; ++i)
                {
                    var filename = filenames[i];
                    Console.WriteLine(filename);
                    int slides = ppt.Slides.Count;
                    try
                    {
                        ppt.Merge(System.IO.Path.GetFullPath(filename));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                if (args.Length > 1)
                {
                    ppt.SaveAs(System.IO.Path.GetFullPath(args[1]));
                }
                else
                {
                    var dialog = new System.Windows.Forms.SaveFileDialog();
                    dialog.Filter = "PowerPoint |*.pptx;*.ppt|All|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        ppt.SaveAs(dialog.FileName);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
