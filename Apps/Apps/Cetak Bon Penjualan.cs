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
    public partial class Cetak_Bon_Penjualan : Form
    {
        Apps.Models.Transaction transaction;

        public Cetak_Bon_Penjualan()
        {
            InitializeComponent();
        }

        public Cetak_Bon_Penjualan(Models.Transaction transaction) {
            InitializeComponent();
            this.transaction = transaction;
        }

        private void setViews() {
            dataGridView1.RowHeadersVisible = false;
            if (transaction != null) {
                namaCustomer.Text = transaction.tujuan.nama;
                alamatCustomer.Text = transaction.tujuan.alamat;
                telpCustomer.Text = transaction.tujuan.telepon;
                noFaktur.Text = transaction.invoice_no;
                tanggal.Text = transaction.tgl_invoice;

                int totalDiskon = 0;
                int totalSub = 0;
                int total = 0;

                DataSet dataSet = new DataSet();
                dataSet.Tables[0].Columns.Add("ID");
                dataSet.Tables[0].Columns.Add("Nama Barang");
                dataSet.Tables[0].Columns.Add("Qty");
                dataSet.Tables[0].Columns.Add("Satuan");
                dataSet.Tables[0].Columns.Add("@");
                dataSet.Tables[0].Columns.Add("Diskon");
                dataSet.Tables[0].Columns.Add("Jumlah");

                for (int i = 0; i < transaction.produkList.Count; i++) {
                    dataSet.Tables[0].Rows[i][0] = transaction.produkList[i].idProduk;
                    dataSet.Tables[0].Rows[i][1] = transaction.produkList[i].namaProduk;
                    dataSet.Tables[0].Rows[i][2] = transaction.produkList[i].jumlah;
                    dataSet.Tables[0].Rows[i][3] = transaction.produkList[i].jenisSatuan;
                    dataSet.Tables[0].Rows[i][4] = transaction.produkList[i].harga;
                    dataSet.Tables[0].Rows[i][5] = transaction.produkList[i].diskon;
                    dataSet.Tables[0].Rows[i][6] = ((transaction.produkList[i].harga * transaction.produkList[i].jumlah));

                    totalDiskon += transaction.produkList[i].diskon;
                    totalSub += (transaction.produkList[i].harga * transaction.produkList[i].jumlah);

                }
                total = totalSub - totalDiskon;
                dataGridView1.DataSource = dataSet.Tables[0];
                subtotal.Text = Convert.ToString(totalSub);
                disc.Text = Convert.ToString(totalDiskon);
                tot.Text = Convert.ToString(total);

            }
        }

        private void Cetak_Bon_Penjualan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPrint.PerformClick(); 
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
