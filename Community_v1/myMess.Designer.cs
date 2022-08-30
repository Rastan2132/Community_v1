
namespace Community_v1
{
    partial class yourMess
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
            this.mess = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mess
            // 
            this.mess.AutoSize = true;
            this.mess.Location = new System.Drawing.Point(10, 10);
            this.mess.MaximumSize = new System.Drawing.Size(235, 980);
            this.mess.MinimumSize = new System.Drawing.Size(0, 20);
            this.mess.Name = "mess";
            this.mess.Size = new System.Drawing.Size(42, 20);
            this.mess.TabIndex = 0;
            this.mess.Text = "none";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(198, 3);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(55, 11);
            this.time.TabIndex = 1;
            this.time.Text = "12/12/22 12:12";
            // 
            // myMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.time);
            this.Controls.Add(this.mess);
            this.MaximumSize = new System.Drawing.Size(255, 1000);
            this.MinimumSize = new System.Drawing.Size(255, 30);
            this.Name = "myMess";
            this.Size = new System.Drawing.Size(255, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mess;
        private System.Windows.Forms.Label time;
    }
}
