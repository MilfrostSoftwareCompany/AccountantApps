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
            retrieveData();
        }

        private void retrieveData() {
            DataSet custDs = Database.getInstance().getAllSupplierData();
            comboBox1.DataSource= custDs.Tables[0];
            comboBox1.DisplayMember = "nama";
            comboBox1.ValueMember = "id";
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            Apps.Models.Transaction transaction = new Models.Transaction(invoiceNo.Text, idCustomer, tgl.Text, produkList);
            if (Database.getInstance().CreateNewPurchase(transaction)) {
                MessageBox.Show("Data Pembelian telah ditambahkan");
            }
            this.Close();
            
        }


      

        private void namaSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
            }
        }

        private void alamatSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
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
<<<<<<< HEAD
            Add_Barang FormAddBarang = new Add_Barang();
            FormAddBarang.ShowDialog();
=======

>>>>>>> a251ea4147ddc338e8c02afe013fc223de336c0c
        }
    }
}
