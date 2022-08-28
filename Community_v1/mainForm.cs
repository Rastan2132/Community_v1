using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Community_v1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            string path = @"..\..\..\log\lognote.txt";
            string[] strok = File.ReadAllLines(path);

            if (strok.Length == 0)
            {
                login login = new login();
                login.Owner = this;
                login.ShowDialog();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
