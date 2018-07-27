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

        Apps.Models.Customer idCustomer;
        List<Apps.Models.Product> produkList;
        List<Apps.Models.Customer> customerList = new List<Models.Customer>();
        public Add_Penjualan()
        {
            InitializeComponent();
            retrieveData();
        }

        private void retrieveData()
        {
            DataSet custDs = Database.getInstance().getAllSupplierData();
            comboBox1.DataSource = custDs.Tables[0];
            comboBox1.DisplayMember = "Nama";
            comboBox1.ValueMember = "ID";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (jatuhTempo.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
                
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
                //alamatCustomer.Focus();
            }
        }

        private void alamatCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //wilayah.Focus();
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
            Add_Barang FormAddBarang = new Add_Barang(this);
            FormAddBarang.ShowDialog();
        }
    }
}
