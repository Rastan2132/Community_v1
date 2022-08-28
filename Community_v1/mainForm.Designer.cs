
namespace Community_v1
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.top = new System.Windows.Forms.Panel();
            this.panelOfMess = new System.Windows.Forms.Panel();
            this.cueTextBox1 = new Community_v1.CueTextBox();
            this.panelOfMess.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.AutoSize = true;
            this.top.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.MinimumSize = new System.Drawing.Size(818, 34);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(818, 34);
            this.top.TabIndex = 3;
            // 
            // panelOfMess
            // 
            this.panelOfMess.AutoScroll = true;
            this.panelOfMess.AutoSize = true;
            this.panelOfMess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOfMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelOfMess.Controls.Add(this.cueTextBox1);
            this.panelOfMess.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOfMess.Location = new System.Drawing.Point(0, 34);
            this.panelOfMess.MinimumSize = new System.Drawing.Size(293, 300);
            this.panelOfMess.Name = "panelOfMess";
            this.panelOfMess.Size = new System.Drawing.Size(293, 416);
            this.panelOfMess.TabIndex = 4;
            // 
            // cueTextBox1
            // 
            this.cueTextBox1.Cue = null;
            this.cueTextBox1.Location = new System.Drawing.Point(8, 7);
            this.cueTextBox1.Name = "cueTextBox1";
            this.cueTextBox1.Size = new System.Drawing.Size(256, 27);
            this.cueTextBox1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOfMess);
            this.Controls.Add(this.top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelOfMess.ResumeLayout(false);
            this.panelOfMess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel panelOfMess;
        private CueTextBox cueTextBox1;
    }
}