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
    public partial class Retur_Pembelian : Form
    {
        Models.Transaction transaction;
        DataSet ds;

        List<Models.Product> addedProduct = new List<Models.Product>();
        List<Models.Product> removedProduct = new List<Models.Product>();

        public Retur_Pembelian(Models.Transaction transaction,string title)
        {
            this.transaction = transaction;
            InitializeComponent();
            label3.Text = title;
            GetData();
            SetViews();
            
        }

        private void GetData()
        {
            transaction.tujuan = Database.getInstance().GetSupplierFromId(transaction.tujuan.id);
            ds = new DataSet();
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("ID");
            ds.Tables[0].Columns.Add("Nama Produk");
            ds.Tables[0].Columns.Add("Jumlah");
            ds.Tables[0].Columns.Add("Satuan");
            ds.Tables[0].Columns.Add("Harga");
            ds.Tables[0].Columns.Add("Diskon");
            ds.Tables[0].Columns.Add("Subtotal");

            for(int i = 0; i < transaction.produkList.Count; i++)
            {
                addedProduct.Add(transaction.produkList[i]);
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = transaction.produkList[i].idProduk;
                dr[1] = transaction.produkList[i].namaProduk;
                dr[2] = transaction.produkList[i].jumlah;
                dr[3] = transaction.produkList[i].jenisSatuan;
                dr[4] = transaction.produkList[i].harga;
                dr[5] = transaction.produkList[i].diskon;
                dr[6] = Convert.ToInt64(transaction.produkList[i].harga)*Convert.ToInt64(transaction.produkList[i].jumlah);
                ds.Tables[0].Rows.Add(dr);
                
            }
            dataGridView1.DataSource = ds.Tables[0];
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Actions";
            dataGridView1.Columns.Add(col);
        }

        public void SetViews()
        {
            if (label3.Text == "RETUR PEMBELIAN")
            {
                label4.Text = "Nama Supplier";
            }
            else if (label3.Text == "RETUR PENJUALAN") {
                label4.Text = "Nama Customer";
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            namasupplier.Text = transaction.tujuan.nama;
            alamat.Text = transaction.tujuan.alamat;
            noFaktur.Text = transaction.invoice_no;

            UpdateCalculation();
            
        }

        private void UpdateCalculation() {
            int subtotal_ = 0;
            int diskon_ = 0;
            int total_ = 0;

            for (int i = 0; i < transaction.produkList.Count; i++)
            {
                subtotal_ += (transaction.produkList[i].harga * transaction.produkList[i].jumlah);
                diskon_ += (transaction.produkList[i].diskon);

            }

            subtotal.Text = Convert.ToString(subtotal_);
            disc.Text = Convert.ToString(diskon_);
            total.Text = Convert.ToString(subtotal_ - diskon_);
        }

        public void AddProduct(Models.Product product) {
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = product.idProduk;
            dr[1] = product.namaProduk;
            dr[2] = product.jumlah;
            dr[3] = product.jenisSatuan;
            dr[4] = product.harga;
            dr[5] = product.diskon;
            dr[6] = Convert.ToInt64(product.harga) * Convert.ToInt64(product.jumlah);
            ds.Tables[0].Rows.Add(dr);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void tambahProdukBtn_Click(object sender, EventArgs e)
        {
            if (removedProduct.Count == 0)
            {
                MessageBox.Show("Tidak ada barang yang bisa ditambahkan.");
            }
            else
            {
                Add_Barang add_Barang = new Add_Barang(this, removedProduct);
                add_Barang.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                removedProduct.Add(addedProduct[e.RowIndex]);
                addedProduct.RemoveAt(e.RowIndex);
                ds.Tables[0].Rows.RemoveAt(e.RowIndex);
            }
        }

        private void buttonRetur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Silahkan isi ID Retur");
            }
            else
            {
                Models.ReturTransaksi retur = new Models.ReturTransaksi(textBox1.Text, transaction.invoice_no, DateTime.Parse(tanggal.Text).ToString("yyyy-MM-dd"), addedProduct, deskripsi.Text);

                if (label3.Text == "RETUR PEMBELIAN")
                {
                    Database.getInstance().CreateNewPurchaseReturn(retur);
                }
                else if(label3.Text == "RETUR PENJUALAN")
                {
                    Database.getInstance().CreateNewSellReturn(retur);
                }
                this.Close();
            }
        }
    }
}
