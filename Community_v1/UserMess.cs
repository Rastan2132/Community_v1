using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Community_v1
{
    public partial class UserMess : UserControl
    {
        public UserMess(String name, string mess, string data)
        {
            InitializeComponent();

            /////////////////////
            
            NickName.Text = name;
            TimeLastMess.Text = data;
            MessLastText.Text = mess;
        }
    }
}
