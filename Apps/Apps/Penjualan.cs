using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Penjualan : UserControl
    {
        public Penjualan()
        {
            InitializeComponent();
        }

        private void Penjualan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {       
            Add_Penjualan FormAddPenjualan = new Add_Penjualan();
            FormAddPenjualan.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi field pencarian !!");
            }
            else
            {

            }
        }
    }
}
