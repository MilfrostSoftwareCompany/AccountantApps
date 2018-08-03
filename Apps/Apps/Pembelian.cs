using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apps.Classes;

namespace Apps
{
    public partial class Pembelian : UserControl
    {

        int detailBtn = 0;
        DataSet dataSet;
        DataSet dataSet2;
        public Pembelian()
        {
            InitializeComponent();
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeDesign();
            initData();
        }

        private void initData()
        {
            refreshData();
            tabelPembelian.RowHeadersVisible = false;
            SetColumnWidth();
        }

        public void InitializeDesign()
        {
            //search.Location = new Point(15, 13);
            //buttonSearch.Location = new Point(Convert.ToInt32(search.Width) + 30, 10);
            //buttonAddPembelian.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddPembelian.Width) - 15, 10);
            //tabelPembelian.Width = Convert.ToInt32(this.Width - 30);
            //tabelPembelian.Height = Convert.ToInt32(this.Height) - Convert.ToInt32(buttonSearch.Height) - 50;
            //tabelPembelian.Location = new Point(15, Convert.ToInt32(buttonSearch.Height) + 30);
        }

        public void refreshData()
        {
            LoadSupplierData();
            //tabelPembelian.Update();
            //tabelPembelian.Refresh();
            SetColumnWidth();
        }
        public void addData(Models.Transaction pembelian) {
            DataRow dr = dataSet.Tables[0].NewRow();
            string nl = Environment.NewLine;
            string productList = "";
            string hargaList = "";
            string kuantitasList = "";
            string satuanList = "";
            string diskonList = "";
            string jlhList = "";
            dr[0] = pembelian.invoice_no;
            dr[1] = pembelian.tujuan.nama;
            dr[2] = pembelian.tgl_invoice;
            for (int i = 0; i < pembelian.produkList.Count; i++) {
                if (i == pembelian.produkList.Count - 1)
                {
                    productList += pembelian.produkList[i].namaProduk;
                    hargaList += pembelian.produkList[i].harga;
                    kuantitasList += pembelian.produkList[i].jumlah;
                    satuanList += pembelian.produkList[i].jenisSatuan;
                    diskonList += pembelian.produkList[i].diskon;
                    jlhList += pembelian.produkList[i].getTotal();
                }
                else
                {
                    productList += pembelian.produkList[i].namaProduk + nl;
                    hargaList += pembelian.produkList[i].harga + nl;
                    kuantitasList += pembelian.produkList[i].jumlah + nl;
                    satuanList += pembelian.produkList[i].jenisSatuan + nl;
                    diskonList += pembelian.produkList[i].diskon + nl;
                    jlhList += pembelian.produkList[i].getTotal() + nl;
                }
            }
            dr[3] = productList;
            dr[4] = hargaList;
            dr[5] = kuantitasList;
            dr[6] = satuanList;
            dr[7] = diskonList;
            dr[8] = jlhList;
            dataSet.Tables[0].Rows.Add(dr);
            tabelPembelian.Update();
            tabelPembelian.Refresh();
            MessageBox.Show("Data Pembelian telah ditambahkan");
        }
        private void setDataGrid() {

        }

        private void LoadReturData()
        {
            dataSet2 = Database.getInstance().GetAllPurchaseReturn();
            dataGridView1.DataSource = dataSet2.Tables[0];
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "View Details";
            col.Name = "Actions";
            tabelPembelian.Columns.Add(col);
        }

        public void AddRetur(Apps.Models.ReturTransaksi returTransaksi)
        {
            DataRow dr = dataSet2.Tables[0].NewRow();
            dr[0] = returTransaksi.idRetur;
            dr[1] = returTransaksi.idTransaksi;
            dr[2] = returTransaksi.tglRetur;
            dr[3] = returTransaksi.supplier.nama;
            dr[4] = returTransaksi.GetTotalPrice();
            dataSet2.Tables[0].Rows.Add(dr);
            dataGridView1.Update();
            dataGridView1.Refresh();
            MessageBox.Show("Retur telah ditambahkan");
        }

        private void LoadSupplierData()
        {

            Database database = Database.getInstance();
             dataSet = database.GetAllPurchase();

            tabelPembelian.DataSource = dataSet.Tables[0];
            dataSet.Tables[0].Columns.Add("Produk");
            dataSet.Tables[0].Columns.Add("Qty");
            dataSet.Tables[0].Columns.Add("Satuan");
            dataSet.Tables[0].Columns.Add("Harga");
            dataSet.Tables[0].Columns.Add("Diskon");
            dataSet.Tables[0].Columns.Add("Jumlah");

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                DataSet newDataSet = database.GetAllRelatedProductPurchase(dataSet.Tables[0].Rows[i][0].ToString());
                string nl = Environment.NewLine;
                string productList = "";
                string hargaList = "";
                string kuantitasList = "";
                string satuanList = "";
                string diskonList = "";
                string jlhList = "";
                for (int j = 0; j < newDataSet.Tables[0].Rows.Count; j++)
                {
                    if (j == newDataSet.Tables[0].Rows.Count - 1)
                    {
                        productList += newDataSet.Tables[0].Rows[j][0].ToString();
                        hargaList += newDataSet.Tables[0].Rows[j][3].ToString();
                        kuantitasList += newDataSet.Tables[0].Rows[j][1].ToString();
                        satuanList += newDataSet.Tables[0].Rows[j][2].ToString();
                        diskonList += newDataSet.Tables[0].Rows[j][4].ToString();
                        jlhList += newDataSet.Tables[0].Rows[j][5].ToString();
                    }
                    else
                    {
                        productList += newDataSet.Tables[0].Rows[j][0].ToString() + nl;
                        hargaList += newDataSet.Tables[0].Rows[j][3].ToString() + nl;
                        kuantitasList += newDataSet.Tables[0].Rows[j][1].ToString() + nl;
                        satuanList += newDataSet.Tables[0].Rows[j][2].ToString() + nl;
                        diskonList += newDataSet.Tables[0].Rows[j][4].ToString() + nl;
                        jlhList += newDataSet.Tables[0].Rows[j][5].ToString() + nl;
                    }
                }
                dataSet.Tables[0].Rows[i][3] = productList;
                dataSet.Tables[0].Rows[i][4] = kuantitasList;
                dataSet.Tables[0].Rows[i][5] = satuanList;
                dataSet.Tables[0].Rows[i][6] = hargaList;
                dataSet.Tables[0].Rows[i][7] = diskonList;
                dataSet.Tables[0].Rows[i][8] = jlhList;
            }
            tabelPembelian.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tabelPembelian.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            

        }

        private void SetColumnWidth()
        {
            if (detailBtn == 0) { 
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "View Details";
                col.Name = "Actions";
                tabelPembelian.Columns.Add(col);
                detailBtn += 1;
            }
            tabelPembelian.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelPembelian.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                refreshData();
                MessageBox.Show("Harus mengisi field pencarian !!");
                search.Focus();
            }
            else
            {

            }
        }

        private void buttonAddPembelian_Click(object sender, EventArgs e)
        {
            Add_Pembelian FormAddPembelian = new Add_Pembelian(this);
            FormAddPembelian.ShowDialog();
        }

        private void buttonAddPembelian_Click_1(object sender, EventArgs e)
        {
            Add_Pembelian FormAddPembelian = new Add_Pembelian(this);
            FormAddPembelian.ShowDialog();
        }

        private void tabelPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                MessageBox.Show("Hello");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {

            }
        }
    }
}
