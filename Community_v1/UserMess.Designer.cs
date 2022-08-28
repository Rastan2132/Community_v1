
namespace Community_v1
{
    partial class UserMess
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
            this.NickName = new System.Windows.Forms.Label();
            this.Mess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NickName
            // 
            this.NickName.AutoSize = true;
            this.NickName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NickName.Location = new System.Drawing.Point(75, 10);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(63, 28);
            this.NickName.TabIndex = 1;
            this.NickName.Text = "None";
            // 
            // Mess
            // 
            this.Mess.AutoSize = true;
            this.Mess.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Mess.Location = new System.Drawing.Point(75, 40);
            this.Mess.Name = "Mess";
            this.Mess.Size = new System.Drawing.Size(45, 20);
            this.Mess.TabIndex = 2;
            this.Mess.Text = "None";
            // 
            // UserMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.Mess);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserMess";
            this.Size = new System.Drawing.Size(290, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Label Mess;
    }
}
