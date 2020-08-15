using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Core = Microsoft.Office.Core;

namespace ppt_autoplay
{
    public partial class Form1 : Form
    {
        public string filename_;
        public Form1(string filename)
        {
            InitializeComponent();
            if (filename == "")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Power Point File(*.pptx,*.ppt)|*.pptx;*.ppt|All Files(*.*)|*.*";
                ofd.Title = "Open file";
                ofd.FileName = "";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                }
            }
            filename_ = System.IO.Path.GetFullPath(filename);
            var stem = System.IO.Path.GetFileNameWithoutExtension(filename);
            var ext = System.IO.Path.GetExtension(filename);
            filenameTextBox.Text = System.IO.Path.GetDirectoryName(filename_) + "\\" + stem + ".autoplay" + ext;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            var app = new PowerPoint.Application();
            var ppt = app.Presentations.Open(System.IO.Path.GetFullPath(filename_), Core.MsoTriState.msoFalse, Core.MsoTriState.msoFalse, Core.MsoTriState.msoFalse);
            for (int i = 1; i <= ppt.Slides.Count; ++i)
            {
                var slide = ppt.Slides[i];
                for (int si = 1; si <= slide.Shapes.Count; ++si)
                {
                    var shape = slide.Shapes[si];
                    if (shape.Type == Core.MsoShapeType.msoMedia)
                    {
                        shape.AnimationSettings.PlaySettings.LoopUntilStopped = loopCheckBox.Checked ? Core.MsoTriState.msoTrue : Core.MsoTriState.msoFalse;
                        shape.AnimationSettings.PlaySettings.PlayOnEntry = autoplayCheckBox.Checked ? Core.MsoTriState.msoTrue : Core.MsoTriState.msoFalse;
                        shape.AnimationSettings.PlaySettings.RewindMovie = rewindCheckBox.Checked ? Core.MsoTriState.msoTrue : Core.MsoTriState.msoFalse;
                        shape.AnimationSettings.AdvanceMode = PowerPoint.PpAdvanceMode.ppAdvanceOnTime;
                        shape.AnimationSettings.AdvanceTime = 0;
                        shape.AnimationSettings.Animate = Core.MsoTriState.msoTrue;
                    }
                }
            }
            try
            {
                if (overwriteCheckBox.Checked)
                {
                    ppt.Save();
                }
                else
                {
                    ppt.SaveAs(filenameTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ppt.Close();
            Application.Exit();
        }
    }
}
