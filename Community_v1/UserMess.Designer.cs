
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
            this.MessLastText = new System.Windows.Forms.Label();
            this.TimeLastMess = new System.Windows.Forms.Label();
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
            // MessLastText
            // 
            this.MessLastText.AutoSize = true;
            this.MessLastText.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MessLastText.Location = new System.Drawing.Point(75, 40);
            this.MessLastText.Name = "MessLastText";
            this.MessLastText.Size = new System.Drawing.Size(45, 20);
            this.MessLastText.TabIndex = 2;
            this.MessLastText.Text = "None";
            // 
            // TimeLastMess
            // 
            this.TimeLastMess.AutoSize = true;
            this.TimeLastMess.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TimeLastMess.Location = new System.Drawing.Point(228, 10);
            this.TimeLastMess.Name = "TimeLastMess";
            this.TimeLastMess.Size = new System.Drawing.Size(55, 11);
            this.TimeLastMess.TabIndex = 3;
            this.TimeLastMess.Text = "12/12/22 12:12";
            // 
            // UserMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.TimeLastMess);
            this.Controls.Add(this.MessLastText);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(285, 70);
            this.Name = "UserMess";
            this.Size = new System.Drawing.Size(285, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Label MessLastText;
        private System.Windows.Forms.Label TimeLastMess;
    }
}
