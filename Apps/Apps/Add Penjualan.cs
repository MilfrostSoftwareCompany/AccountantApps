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
    public partial class Add_Penjualan : Form
    {
        public Add_Penjualan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cetak_Bon_Penjualan FormCetakBonPenjualan = new Cetak_Bon_Penjualan();
            FormCetakBonPenjualan.ShowDialog();
            this.Close();
        }
    }
}
