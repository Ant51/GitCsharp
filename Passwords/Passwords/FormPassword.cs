﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Passwords
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void LlSite1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((string)((LinkLabel)sender).Tag);
        }

        private void Tblogin1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((TextBox)sender).Text);
            ((TextBox)sender).SelectAll();
        }

        private void BtPassword1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText((string)((Button)sender).Tag);
            Close();
        }
    }
}
