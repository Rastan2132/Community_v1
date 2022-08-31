
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NameOfYourFrend = new System.Windows.Forms.Label();
            this.pictureForYourFrend = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panelMess = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cueTextBox1 = new Community_v1.CueTextBox();
            this.fileEnter = new System.Windows.Forms.PictureBox();
            this.Enter = new System.Windows.Forms.PictureBox();
            this.messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForYourFrend)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelMess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.NameOfYourFrend);
            this.panel1.Controls.Add(this.pictureForYourFrend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 40);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(422, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(381, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(455, 335);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.flowLayoutPanel2.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox7);
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
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(3, 85);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // panelMess
            // 
            this.panelMess.AutoSize = true;
            this.panelMess.Controls.Add(this.pictureBox1);
            this.panelMess.Controls.Add(this.pictureBox2);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(428, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureForYourFrend)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelMess.ResumeLayout(false);
            this.panelMess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CueTextBox cueTextBox1;
        private System.Windows.Forms.PictureBox fileEnter;
        private System.Windows.Forms.PictureBox Enter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label NameOfYourFrend;
        private System.Windows.Forms.PictureBox pictureForYourFrend;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}