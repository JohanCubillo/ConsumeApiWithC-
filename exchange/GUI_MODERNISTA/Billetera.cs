﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Billetera : Form
    {
        public Billetera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProximaCripto pro = new ProximaCripto();
            pro.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ProximaCripto pro = new ProximaCripto();
            pro.Show();
        }
    }
}
