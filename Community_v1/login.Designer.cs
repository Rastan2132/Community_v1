
namespace Community_v1
{
    partial class login
    {
    
        
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginText = new Community_v1.CueTextBox();
            this.passwordText = new Community_v1.CueTextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.or = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.password_see = new System.Windows.Forms.PictureBox();
            this.icon_lock = new System.Windows.Forms.PictureBox();
            this.icon_user = new System.Windows.Forms.PictureBox();
            this.Text_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.Panel();
            this.Down_login = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_see)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Down_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.loginText);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.or);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.password_see);
            this.panel1.Controls.Add(this.icon_lock);
            this.panel1.Controls.Add(this.icon_user);
            this.panel1.Controls.Add(this.Text_login);
            this.panel1.Location = new System.Drawing.Point(76, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 247);
            this.panel1.TabIndex = 0;
            // 
            // loginText
            // 
            this.loginText.Cue = "e-mail";
            this.loginText.Location = new System.Drawing.Point(58, 57);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(139, 27);
            this.loginText.TabIndex = 10;
            // 
            // passwordText
            // 
            this.passwordText.Cue = "password";
            this.passwordText.Location = new System.Drawing.Point(58, 91);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(139, 27);
            this.passwordText.TabIndex = 9;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(58, 187);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(139, 29);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Регистрироватся";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // or
            // 
            this.or.AutoSize = true;
            this.or.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.or.ForeColor = System.Drawing.Color.White;
            this.or.Location = new System.Drawing.Point(110, 163);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(36, 20);
            this.or.TabIndex = 7;
            this.or.Text = "или";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(58, 132);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(139, 29);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // password_see
            // 
            this.password_see.Image = global::Community_v1.Properties.Resources.password_lock_icon;
            this.password_see.Location = new System.Drawing.Point(206, 87);
            this.password_see.Name = "password_see";
            this.password_see.Size = new System.Drawing.Size(30, 30);
            this.password_see.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.password_see.TabIndex = 5;
            this.password_see.TabStop = false;
            this.password_see.Click += new System.EventHandler(this.password_see_Click);
            // 
            // icon_lock
            // 
            this.icon_lock.Image = global::Community_v1.Properties.Resources.lock_icon;
            this.icon_lock.Location = new System.Drawing.Point(29, 91);
            this.icon_lock.Name = "icon_lock";
            this.icon_lock.Size = new System.Drawing.Size(25, 25);
            this.icon_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_lock.TabIndex = 2;
            this.icon_lock.TabStop = false;
            // 
            // icon_user
            // 
            this.icon_user.Image = global::Community_v1.Properties.Resources.user_icon;
            this.icon_user.Location = new System.Drawing.Point(29, 57);
            this.icon_user.Name = "icon_user";
            this.icon_user.Size = new System.Drawing.Size(25, 25);
            this.icon_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_user.TabIndex = 1;
            this.icon_user.TabStop = false;
            // 
            // Text_login
            // 
            this.Text_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_login.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Text_login.ForeColor = System.Drawing.Color.Transparent;
            this.Text_login.Location = new System.Drawing.Point(62, 11);
            this.Text_login.Name = "Text_login";
            this.Text_login.Size = new System.Drawing.Size(135, 25);
            this.Text_login.TabIndex = 0;
            this.Text_login.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.MaximumSize = new System.Drawing.Size(403, 34);
            this.top.MinimumSize = new System.Drawing.Size(403, 34);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(403, 34);
            this.top.TabIndex = 2;
            // 
            // Down_login
            // 
            this.Down_login.Controls.Add(this.label1);
            this.Down_login.Controls.Add(this.Down);
            this.Down_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Down_login.Location = new System.Drawing.Point(0, 417);
            this.Down_login.Name = "Down_login";
            this.Down_login.Size = new System.Drawing.Size(403, 46);
            this.Down_login.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(138, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "2022 © Rostyslav.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Down
            // 
            this.Down.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Down.Location = new System.Drawing.Point(134, 2);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(141, 20);
            this.Down.TabIndex = 0;
            this.Down.Text = "2022 © Community.";
            this.Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 463);
            this.Controls.Add(this.Down_login);
            this.Controls.Add(this.top);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(422, 511);
            this.MinimumSize = new System.Drawing.Size(421, 510);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login in Community.";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_see)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Down_login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel Down_login;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Text_login;
        private System.Windows.Forms.PictureBox icon_lock;
        private System.Windows.Forms.PictureBox icon_user;
        private System.Windows.Forms.PictureBox password_see;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label or;
        private CueTextBox passwordText;
        private CueTextBox loginText;
    }
}

