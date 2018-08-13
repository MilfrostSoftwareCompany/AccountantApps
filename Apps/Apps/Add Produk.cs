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
    public partial class Add_Produk : Form
    {
        Inventori inventori;
        Models.Product product;

        bool isEdit = false;

        public Add_Produk(Inventori inventori)
        {
            this.inventori = inventori;
            InitializeComponent();
            InitializeDesign();
        }

        public Add_Produk(Inventori inventori,Models.Product product)
        {
            this.inventori = inventori;
            this.product = product;
            isEdit = true;
            InitializeComponent();
            InitializeDesign();
            setViews();
        }

        private void setViews()
        {
            namaBarang.Text = product.namaProduk;
            jumlah.Value = product.jumlah;
            jenisSatuan.Text = product.jenisSatuan;
            harga.Value = product.harga;
        }

        public void InitializeDesign()
        {
            buttonSave.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonSave.Width) - 30, Convert.ToInt32(this.Height) - Convert.ToInt32(buttonSave.Height) - 60);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namaBarang.Text)||string.IsNullOrWhiteSpace(jumlah.Text)||string.IsNullOrWhiteSpace(jenisSatuan.Text)||string.IsNullOrWhiteSpace(harga.Text))
            {
                MessageBox.Show("Semua Data harus diisi");
            }
            else
            {
                
                Models.Product product_ = new Models.Product(namaBarang.Text, Convert.ToInt32(jumlah.Value), jenisSatuan.Text, Convert.ToInt32(harga.Value));
                if (isEdit)
                {
                    product_.idProduk = product.idProduk;
                    Database.getInstance().UpdateProduct(product_);
                    inventori.RefreshData();

                }
                else
                {
                    Database.getInstance().CreateNewProduct(product_);
                    inventori.RefreshData();
                }
                this.Close();
            }
        }

        private void comboBoxIdBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                namaBarang.Focus();
            }
        }

        private void StokBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
