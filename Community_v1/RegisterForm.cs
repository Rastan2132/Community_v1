using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Community_v1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        
            public int passIndex = 1;


        private void password_see_Click(object sender, EventArgs e)
        {
            if (passIndex == 1)
            {
                passText.UseSystemPasswordChar = false;
                passText2.UseSystemPasswordChar = false;
                passIndex = 2;
            }
            else
            {
                passText.UseSystemPasswordChar = true;
                passText2.UseSystemPasswordChar = true;
                passIndex = 1;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            passText.UseSystemPasswordChar = true;
            passText2.UseSystemPasswordChar = true;
        }
    }
}
