﻿using System;
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
        public searchUser (String name, string eMail)
        {
            InitializeComponent();
            /////////////////////
            NickName.Text = name;
            eMailText.Text = eMail;
        }
    }
}
