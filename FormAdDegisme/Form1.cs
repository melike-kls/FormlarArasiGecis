﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAdDegisme
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2(this);
            frm1.ShowDialog();
        }
    }
}
