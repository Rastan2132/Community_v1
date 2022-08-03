
namespace Community_v1
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.passwordText_too = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.password_see = new System.Windows.Forms.PictureBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.icon_lock = new System.Windows.Forms.PictureBox();
            this.icon_user = new System.Windows.Forms.PictureBox();
            this.Text_Register = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_see)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_user)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.top.AutoSize = true;
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.top.Cursor = System.Windows.Forms.Cursors.Default;
            this.top.Location = new System.Drawing.Point(-5, 0);
            this.top.MaximumSize = new System.Drawing.Size(600, 34);
            this.top.MinimumSize = new System.Drawing.Size(450, 34);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(600, 34);
            this.top.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 41);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(139, 93);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(139, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.passwordText_too);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.password_see);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.loginText);
            this.panel1.Controls.Add(this.icon_lock);
            this.panel1.Controls.Add(this.icon_user);
            this.panel1.Controls.Add(this.Text_Register);
            this.panel1.Location = new System.Drawing.Point(100, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 564);
            this.panel1.TabIndex = 4;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(58, 175);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(250, 27);
            this.dateTime.TabIndex = 12;
            // 
            // passwordText_too
            // 
            this.passwordText_too.Location = new System.Drawing.Point(58, 133);
            this.passwordText_too.Name = "passwordText_too";
            this.passwordText_too.Size = new System.Drawing.Size(250, 27);
            this.passwordText_too.TabIndex = 9;
            this.passwordText_too.UseSystemPasswordChar = true;
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
            this.buttonRegister.Location = new System.Drawing.Point(124, 328);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(139, 29);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Регистрироватся";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // password_see
            // 
            this.password_see.Image = global::Community_v1.Properties.Resources.password_lock_icon;
            this.password_see.Location = new System.Drawing.Point(317, 117);
            this.password_see.Name = "password_see";
            this.password_see.Size = new System.Drawing.Size(30, 30);
            this.password_see.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.password_see.TabIndex = 5;
            this.password_see.TabStop = false;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(58, 100);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(250, 27);
            this.passwordText.TabIndex = 4;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(58, 57);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(250, 27);
            this.loginText.TabIndex = 3;
            // 
            // icon_lock
            // 
            this.icon_lock.Image = global::Community_v1.Properties.Resources.lock_icon;
            this.icon_lock.Location = new System.Drawing.Point(23, 117);
            this.icon_lock.Name = "icon_lock";
            this.icon_lock.Size = new System.Drawing.Size(25, 25);
            this.icon_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_lock.TabIndex = 2;
            this.icon_lock.TabStop = false;
            // 
            // icon_user
            // 
            this.icon_user.Image = global::Community_v1.Properties.Resources.user_icon;
            this.icon_user.Location = new System.Drawing.Point(23, 57);
            this.icon_user.Name = "icon_user";
            this.icon_user.Size = new System.Drawing.Size(25, 25);
            this.icon_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_user.TabIndex = 1;
            this.icon_user.TabStop = false;
            // 
            // Text_Register
            // 
            this.Text_Register.Location = new System.Drawing.Point(0, 0);
            this.Text_Register.Name = "Text_Register";
            this.Text_Register.Size = new System.Drawing.Size(100, 23);
            this.Text_Register.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 13;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "RegisterForm";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_see)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordText_too;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.PictureBox password_see;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.PictureBox icon_lock;
        private System.Windows.Forms.PictureBox icon_user;
        private System.Windows.Forms.Label Text_Register;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox textBox1;
    }
}