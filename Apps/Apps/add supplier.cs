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
    public partial class Add_Supplier : Form
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string alamat = richTextBox1.Text;
            string telepon = textBox2.Text;

            

            this.Close();
        }
    }
}
