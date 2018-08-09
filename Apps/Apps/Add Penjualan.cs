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

        DataSet ds;
        Penjualan penjualan;
        Apps.Models.Customer idCustomer;
        List<Apps.Models.Product> produkList = new List<Models.Product>();
        List<Apps.Models.Customer> customerList = new List<Models.Customer>();
        public Add_Penjualan(Penjualan penjualan)
        {

            InitializeComponent();
            this.penjualan = penjualan;
            retrieveData();
            ds = new DataSet();
            initDataSource();
            initDataGrid();
            dataGridView1.RowHeadersVisible = false;
        }

        private void retrieveData()
        {
            DataSet custDs = Database.getInstance().getAllSupplierData();
            comboBox1.DataSource = custDs.Tables[0];
            comboBox1.DisplayMember = "Nama";
            comboBox1.ValueMember = "ID";
        }
        private void initDataGrid()
        {
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            setDetailsChange(e.RowIndex);
        }

        private void setDetailsChange(int row)
        {
            //update data
            produkList[row].jumlah = Convert.ToInt32(ds.Tables[0].Rows[row][2].ToString());
            produkList[row].harga = Convert.ToInt32(ds.Tables[0].Rows[row][5].ToString());
            produkList[row].diskon = Convert.ToInt32(ds.Tables[0].Rows[row][6].ToString());
            ds.Tables[0].Rows[row][7] = (produkList[row].harga * produkList[row].jumlah) - produkList[row].diskon;

            subtotal.Text = "Rp. " + calculateSubtotal();
            disc.Text = "Rp. " + calculateDisc();
            total.Text = "Rp. " + calculateTotal();


        }

        private void initDataSource()
        {
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("No.");
            ds.Tables[0].Columns.Add("ID Produk");
            ds.Tables[0].Columns.Add("Jlh");
            ds.Tables[0].Columns.Add("Satuan");
            ds.Tables[0].Columns.Add("Nama Produk");
            ds.Tables[0].Columns.Add("Harga");
            ds.Tables[0].Columns.Add("Diskon");
            ds.Tables[0].Columns.Add("Total");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private int calculateSubtotal()
        {
            int sub = 0;
            foreach (Models.Product pro in produkList)
            {
                sub += (pro.jumlah * pro.harga);
            }
            return sub;
        }

        private int calculateDisc()
        {
            int sub = 0;
            foreach (Models.Product pro in produkList)
            {
                sub += pro.diskon;
            }
            return sub;
        }
        private int calculateTotal()
        {
            int sub = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sub += Convert.ToInt32(ds.Tables[0].Rows[i][7]);
            }
            return sub;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (tglJatuhTempo.Text.Length == 0)
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
                tglJatuhTempo.Focus();
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

        public void AddProdukToTable(Models.Product product)
        {

            produkList.Add(product);


            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = ds.Tables[0].Rows.Count;
            dr[1] = product.idProduk;
            dr[2] = product.jumlah;
            dr[3] = product.jenisSatuan;
            dr[4] = product.namaProduk;
            dr[5] = product.harga;
            dr[6] = product.diskon;
            dr[7] = (product.harga * product.jumlah) - product.diskon;

            ds.Tables[0].Rows.Add(dr);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("index = " + e.ColumnIndex);
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Produk telah dihapus");
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                produkList.RemoveAt(e.RowIndex);
            }
        }
    }
}
