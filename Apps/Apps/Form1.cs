using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            master_Data_Panel1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            master_Data_Panel1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            master_Data_Panel1.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            transaksi_Panel1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            laporan_Panel1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pemeliharaan_Panel1.BringToFront();
        }
    }
}
