
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
            this.messages = new System.Windows.Forms.FlowLayoutPanel();
            this.searchUserText = new Community_v1.CueTextBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
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
            // messages
            // 
            this.messages.AutoScroll = true;
            this.messages.AutoSize = true;
            this.messages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.messages.Controls.Add(this.searchUserText);
            this.messages.Controls.Add(this.searchButton);
            this.messages.Dock = System.Windows.Forms.DockStyle.Left;
            this.messages.Location = new System.Drawing.Point(0, 34);
            this.messages.MinimumSize = new System.Drawing.Size(300, 416);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(300, 416);
            this.messages.TabIndex = 4;
            this.messages.Paint += new System.Windows.Forms.PaintEventHandler(this.messages_Paint);
            // 
            // searchUserText
            // 
            this.searchUserText.Cue = null;
            this.searchUserText.Location = new System.Drawing.Point(3, 3);
            this.searchUserText.MaximumSize = new System.Drawing.Size(255, 27);
            this.searchUserText.MinimumSize = new System.Drawing.Size(255, 27);
            this.searchUserText.Name = "searchUserText";
            this.searchUserText.Size = new System.Drawing.Size(255, 27);
            this.searchUserText.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Image = global::Community_v1.Properties.Resources.search_icon;
            this.searchButton.Location = new System.Drawing.Point(264, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(27, 27);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 1;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.messages.ResumeLayout(false);
            this.messages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.FlowLayoutPanel messages;
        private CueTextBox searchUserText;
        private System.Windows.Forms.PictureBox searchButton;
    }
}