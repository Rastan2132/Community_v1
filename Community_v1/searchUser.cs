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
        public searchUser (String name, string eMail, int id_a, int Id_b, mainForm form)
        {
            InitializeComponent();
            /////////////////////
            NickName.Text = name;
            eMailText.Text = eMail;
            this.form = form;
        }
        private mainForm form;

        private void searchUser_Click(object sender, EventArgs e)
        {
            this.form.labelName = NickName.Text;
          //  mainForm.NameOfYourFrend.Text = NickName.Text;
            this.Visible = false;
            
        }

        private void searchUser_Load(object sender, EventArgs e)
        {

        }
    }
}
