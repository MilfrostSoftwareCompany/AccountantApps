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
    public partial class Retur_Pembelian : Form
    {
        Models.Transaction transaction;
        DataSet ds;
        public Retur_Pembelian(Models.Transaction transaction)
        {
            this.transaction = transaction;
            InitializeComponent();
            GetData();
            SetViews();
        }

        private void GetData()
        {

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
        }

        public void SetViews()
        {
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

        private void tambahProdukBtn_Click(object sender, EventArgs e)
        {
            Add_Barang add_Barang = new Add_Barang(this,transaction.produkList);
            add_Barang.ShowDialog();
        }
    }
}
