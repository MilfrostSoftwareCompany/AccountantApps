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
    public partial class Add_Penjualan : Form
    {
        public Add_Penjualan()
        {
            InitializeComponent();
            namaCustomer.Focus();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (namaCustomer.Text.Length == 0 || alamatCustomer.Text.Length == 0 || wilayah.Text.Length == 0 || jatuhTempo.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
                if (namaCustomer.Text.Length == 0) { namaCustomer.Focus(); }
                else if (alamatCustomer.Text.Length == 0) { alamatCustomer.Focus(); }
                else if (wilayah.Text.Length == 0) { wilayah.Focus(); }
                else { jatuhTempo.Focus(); }
            }
            else
            {
                Cetak_Bon_Penjualan FormCetakBonPenjualan = new Cetak_Bon_Penjualan();
                FormCetakBonPenjualan.ShowDialog();
                this.Close();
            }
        }

        private void namaCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                alamatCustomer.Focus();
            }
        }

        private void alamatCustomer_KeyDown(object sender, KeyEventArgs e)
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

        private void buttonAddBarang_Click(object sender, EventArgs e)
        {
            Add_Barang FormAddBarang = new Add_Barang();
            FormAddBarang.ShowDialog();
        }
    }
}
