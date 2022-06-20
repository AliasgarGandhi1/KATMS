﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KATMS.GUI
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            progressbar.Minimum = 0;
            progressbar.Maximum = 100;

            for (int i = 0; i <= 100; i++)
                    progressbar.Value = i;

            if (progressbar.Value == 100)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
