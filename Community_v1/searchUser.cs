using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Community_v1 
{
    public partial class searchUser  : UserControl 
    {
        public searchUser (String name, string eMail, int id_a, int Id_b)
        {
            InitializeComponent();
            /////////////////////
            NickName.Text = name;
            eMailText.Text = eMail;
        }

        private void searchUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           // NameOfYourFrend.text = name;
        }

        private void searchUser_Load(object sender, EventArgs e)
        {

        }
    }
}
