
namespace Community_v1
{
    partial class searchUser
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eMailText = new System.Windows.Forms.Label();
            this.NickName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Community_v1.Properties.Resources.user_icon2;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // eMailText
            // 
            this.eMailText.AutoSize = true;
            this.eMailText.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.eMailText.Location = new System.Drawing.Point(75, 40);
            this.eMailText.Name = "eMailText";
            this.eMailText.Size = new System.Drawing.Size(45, 20);
            this.eMailText.TabIndex = 4;
            this.eMailText.Text = "None";
            // 
            // NickName
            // 
            this.NickName.AutoSize = true;
            this.NickName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NickName.Location = new System.Drawing.Point(75, 10);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(63, 28);
            this.NickName.TabIndex = 3;
            this.NickName.Text = "None";
            // 
            // searchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.eMailText);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(290, 70);
            this.Name = "searchUser";
            this.Size = new System.Drawing.Size(290, 70);
            this.Load += new System.EventHandler(this.searchUser_Load);
            this.Click += new System.EventHandler(this.searchUser_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eMailText;
        private System.Windows.Forms.Label NickName;
    }
}
