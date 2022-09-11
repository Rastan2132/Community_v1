
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoCall = new System.Windows.Forms.PictureBox();
            this.audioСall = new System.Windows.Forms.PictureBox();
            this.NameOfYourFrend = new System.Windows.Forms.Label();
            this.pictureForYourFrend = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panelMess = new System.Windows.Forms.Panel();
            this.enterMess = new System.Windows.Forms.PictureBox();
            this.enterFile = new System.Windows.Forms.PictureBox();
            this.cueTextBox1 = new Community_v1.CueTextBox();
            this.fileEnter = new System.Windows.Forms.PictureBox();
            this.Enter = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioСall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForYourFrend)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panelMess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enter)).BeginInit();
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
            this.top.Paint += new System.Windows.Forms.PaintEventHandler(this.top_Paint);
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
            this.searchUserText.Cue = "search for nickname";
            this.searchUserText.Location = new System.Drawing.Point(3, 3);
            this.searchUserText.Name = "searchUserText";
            this.searchUserText.Size = new System.Drawing.Size(255, 27);
            this.searchUserText.TabIndex = 2;
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
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.flowLayoutPanel1);
            this.MainPanel.Controls.Add(this.flowLayoutPanel2);
            this.MainPanel.Controls.Add(this.panelMess);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(300, 34);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(500, 416);
            this.MainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.videoCall);
            this.panel1.Controls.Add(this.audioСall);
            this.panel1.Controls.Add(this.NameOfYourFrend);
            this.panel1.Controls.Add(this.pictureForYourFrend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 40);
            this.panel1.TabIndex = 5;
            // 
            // videoCall
            // 
            this.videoCall.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.videoCall.Image = ((System.Drawing.Image)(resources.GetObject("videoCall.Image")));
            this.videoCall.Location = new System.Drawing.Point(422, 2);
            this.videoCall.Name = "videoCall";
            this.videoCall.Size = new System.Drawing.Size(35, 35);
            this.videoCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoCall.TabIndex = 6;
            this.videoCall.TabStop = false;
            // 
            // audioСall
            // 
            this.audioСall.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.audioСall.Image = ((System.Drawing.Image)(resources.GetObject("audioСall.Image")));
            this.audioСall.Location = new System.Drawing.Point(381, 1);
            this.audioСall.Name = "audioСall";
            this.audioСall.Size = new System.Drawing.Size(35, 35);
            this.audioСall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.audioСall.TabIndex = 5;
            this.audioСall.TabStop = false;
            // 
            // NameOfYourFrend
            // 
            this.NameOfYourFrend.AutoSize = true;
            this.NameOfYourFrend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameOfYourFrend.Location = new System.Drawing.Point(41, 6);
            this.NameOfYourFrend.Name = "NameOfYourFrend";
            this.NameOfYourFrend.Size = new System.Drawing.Size(59, 28);
            this.NameOfYourFrend.TabIndex = 4;
            this.NameOfYourFrend.Text = "none";
            // 
            // pictureForYourFrend
            // 
            this.pictureForYourFrend.Image = global::Community_v1.Properties.Resources.user_icon1;
            this.pictureForYourFrend.Location = new System.Drawing.Point(0, 1);
            this.pictureForYourFrend.Name = "pictureForYourFrend";
            this.pictureForYourFrend.Size = new System.Drawing.Size(35, 35);
            this.pictureForYourFrend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureForYourFrend.TabIndex = 3;
            this.pictureForYourFrend.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(455, 335);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.flowLayoutPanel2.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel2.Controls.Add(this.exit);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(460, 0);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(40, 0);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(40, 382);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(40, 382);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 44);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(3, 85);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(35, 35);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 8;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // panelMess
            // 
            this.panelMess.AutoSize = true;
            this.panelMess.Controls.Add(this.enterMess);
            this.panelMess.Controls.Add(this.enterFile);
            this.panelMess.Controls.Add(this.cueTextBox1);
            this.panelMess.Controls.Add(this.fileEnter);
            this.panelMess.Controls.Add(this.Enter);
            this.panelMess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMess.Location = new System.Drawing.Point(0, 373);
            this.panelMess.MinimumSize = new System.Drawing.Size(500, 30);
            this.panelMess.Name = "panelMess";
            this.panelMess.Size = new System.Drawing.Size(500, 43);
            this.panelMess.TabIndex = 3;
            // 
            // enterMess
            // 
            this.enterMess.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enterMess.Image = ((System.Drawing.Image)(resources.GetObject("enterMess.Image")));
            this.enterMess.Location = new System.Drawing.Point(392, 10);
            this.enterMess.Name = "enterMess";
            this.enterMess.Size = new System.Drawing.Size(30, 30);
            this.enterMess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enterMess.TabIndex = 5;
            this.enterMess.TabStop = false;
            this.enterMess.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // enterFile
            // 
            this.enterFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enterFile.Image = ((System.Drawing.Image)(resources.GetObject("enterFile.Image")));
            this.enterFile.Location = new System.Drawing.Point(428, 10);
            this.enterFile.Name = "enterFile";
            this.enterFile.Size = new System.Drawing.Size(30, 30);
            this.enterFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enterFile.TabIndex = 4;
            this.enterFile.TabStop = false;
            this.enterFile.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cueTextBox1
            // 
            this.cueTextBox1.AcceptsReturn = true;
            this.cueTextBox1.AllowDrop = true;
            this.cueTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cueTextBox1.Cue = "Your Message";
            this.cueTextBox1.Location = new System.Drawing.Point(3, 10);
            this.cueTextBox1.MinimumSize = new System.Drawing.Size(369, 27);
            this.cueTextBox1.Name = "cueTextBox1";
            this.cueTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cueTextBox1.Size = new System.Drawing.Size(383, 27);
            this.cueTextBox1.TabIndex = 3;
            this.cueTextBox1.TextChanged += new System.EventHandler(this.cueTextBox1_TextChanged);
            // 
            // fileEnter
            // 
            this.fileEnter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fileEnter.Image = global::Community_v1.Properties.Resources.lock_icon;
            this.fileEnter.Location = new System.Drawing.Point(396, -380);
            this.fileEnter.Name = "fileEnter";
            this.fileEnter.Size = new System.Drawing.Size(30, 30);
            this.fileEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileEnter.TabIndex = 2;
            this.fileEnter.TabStop = false;
            // 
            // Enter
            // 
            this.Enter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Enter.Image = global::Community_v1.Properties.Resources.lock_icon;
            this.Enter.Location = new System.Drawing.Point(432, -379);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(30, 30);
            this.Enter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enter.TabIndex = 1;
            this.Enter.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.mainForm_ResizeEnd);
            this.messages.ResumeLayout(false);
            this.messages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioСall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForYourFrend)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panelMess.ResumeLayout(false);
            this.panelMess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.FlowLayoutPanel messages;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.Panel MainPanel;
        private CueTextBox searchUserText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelMess;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox enterMess;
        private System.Windows.Forms.PictureBox enterFile;
        private CueTextBox cueTextBox1;
        private System.Windows.Forms.PictureBox fileEnter;
        private System.Windows.Forms.PictureBox Enter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox videoCall;
        private System.Windows.Forms.PictureBox audioСall;
        public System.Windows.Forms.Label NameOfYourFrend;
        private System.Windows.Forms.PictureBox pictureForYourFrend;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}