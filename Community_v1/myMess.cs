﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Community_v1
{
    public partial class yourMess : UserControl
    {
        public yourMess(String messedar, DateTime date)
        {
            InitializeComponent();
            mess.Text = messedar;
            time.Text = date.ToString("MMMM dd, yyyy");
        }
    }
}
