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

        Apps.Models.Supplier idCustomer;
        List<Apps.Models.Product> produkList;
        public Add_Pembelian()
        {
            InitializeComponent();
            namaCustomer.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (namaCustomer.Text.Length == 0 || alamatSupplier.Text.Length == 0 || wilayah.Text.Length == 0 || jatuhTempo.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
                if (namaCustomer.Text.Length == 0) { namaCustomer.Focus(); }
                else if (alamatSupplier.Text.Length == 0) { alamatSupplier.Focus(); }
                else if (wilayah.Text.Length == 0) { wilayah.Focus(); }
                else { jatuhTempo.Focus(); }
            }
            else
            {
                Apps.Models.Transaction transaction = new Models.Transaction(invoiceNo.Text,idCustomer,tgl.Text,produkList);
                this.Close();
            }
        }

        private void namaSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                alamatSupplier.Focus();
            }
        }

        private void alamatSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wilayah.Focus();
            }
        }

        private void wilayah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                jatuhTempo.Focus();
            }
        }

        private void jatuhTempo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddBarang.PerformClick();
            }
        }
    }
}
