﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Cetak_Bon_Penjualan : Form
    {
        public Cetak_Bon_Penjualan()
        {
            InitializeComponent();
        }

        private void Cetak_Bon_Penjualan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPrint.PerformClick(); 
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
