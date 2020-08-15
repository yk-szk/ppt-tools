namespace ppt_autoplay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.autoplayCheckBox = new System.Windows.Forms.CheckBox();
            this.rewindCheckBox = new System.Windows.Forms.CheckBox();
            this.loopCheckBox = new System.Windows.Forms.CheckBox();
            this.overwriteCheckBox = new System.Windows.Forms.CheckBox();
            this.runButton = new System.Windows.Forms.Button();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autoplayCheckBox
            // 
            this.autoplayCheckBox.AutoSize = true;
            this.autoplayCheckBox.Checked = true;
            this.autoplayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoplayCheckBox.Location = new System.Drawing.Point(26, 26);
            this.autoplayCheckBox.Name = "autoplayCheckBox";
            this.autoplayCheckBox.Size = new System.Drawing.Size(98, 22);
            this.autoplayCheckBox.TabIndex = 0;
            this.autoplayCheckBox.Text = "autoplay";
            this.autoplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // rewindCheckBox
            // 
            this.rewindCheckBox.AutoSize = true;
            this.rewindCheckBox.Checked = true;
            this.rewindCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rewindCheckBox.Location = new System.Drawing.Point(26, 63);
            this.rewindCheckBox.Name = "rewindCheckBox";
            this.rewindCheckBox.Size = new System.Drawing.Size(83, 22);
            this.rewindCheckBox.TabIndex = 1;
            this.rewindCheckBox.Text = "rewind";
            this.rewindCheckBox.UseVisualStyleBackColor = true;
            // 
            // loopCheckBox
            // 
            this.loopCheckBox.AutoSize = true;
            this.loopCheckBox.Checked = true;
            this.loopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopCheckBox.Location = new System.Drawing.Point(26, 102);
            this.loopCheckBox.Name = "loopCheckBox";
            this.loopCheckBox.Size = new System.Drawing.Size(65, 22);
            this.loopCheckBox.TabIndex = 2;
            this.loopCheckBox.Text = "loop";
            this.loopCheckBox.UseVisualStyleBackColor = true;
            // 
            // overwriteCheckBox
            // 
            this.overwriteCheckBox.AutoSize = true;
            this.overwriteCheckBox.Location = new System.Drawing.Point(26, 140);
            this.overwriteCheckBox.Name = "overwriteCheckBox";
            this.overwriteCheckBox.Size = new System.Drawing.Size(104, 22);
            this.overwriteCheckBox.TabIndex = 3;
            this.overwriteCheckBox.Text = "overwrite";
            this.overwriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.runButton.Location = new System.Drawing.Point(214, 30);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(274, 149);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(26, 240);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(381, 25);
            this.filenameTextBox.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(413, 235);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 34);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output filename";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.overwriteCheckBox);
            this.Controls.Add(this.loopCheckBox);
            this.Controls.Add(this.rewindCheckBox);
            this.Controls.Add(this.autoplayCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ppt-autoplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoplayCheckBox;
        private System.Windows.Forms.CheckBox rewindCheckBox;
        private System.Windows.Forms.CheckBox loopCheckBox;
        private System.Windows.Forms.CheckBox overwriteCheckBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
    }
}

