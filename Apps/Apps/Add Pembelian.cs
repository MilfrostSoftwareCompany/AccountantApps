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
    public partial class Add_Pembelian : Form
    {
        public Add_Pembelian()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (namaSupplier.Text.Length == 0 || alamatSupplier.Text.Length == 0 || wilayah.Text.Length == 0 || jatuhTempo.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
            }
            else
            {
                this.Close();
            }
        }
    }
}
