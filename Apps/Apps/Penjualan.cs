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
    public partial class Penjualan : UserControl
    {

        int detailBtn = 0;
        DataSet dataSet;
        DataSet dataSet2;
        List<Models.Transaction> transList = new List<Models.Transaction>();
        public Penjualan()
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
            dataGridView1.RowHeadersVisible = false;
            tabelPenjualan.RowHeadersVisible = false;
            SetColumnWidth();
            SetReturData();
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
            LoadReturData();
            //tabelPembelian.Update();
            //tabelPembelian.Refresh();
        }
        public void addData(Models.Transaction pembelian)
        {
            transList.Add(pembelian);
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
            for (int i = 0; i < pembelian.produkList.Count; i++)
            {
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
            tabelPenjualan.Update();
            tabelPenjualan.Refresh();
            MessageBox.Show("Data penjualan telah ditambahkan");
            
        }
        public void RefreshSellData()
        {
            tabelPenjualan.Columns.RemoveAt(9);
            tabelPenjualan.Columns.RemoveAt(8);
            tabelPenjualan.Columns.RemoveAt(7);
            tabelPenjualan.Columns.RemoveAt(6);
            tabelPenjualan.Columns.RemoveAt(5);
            tabelPenjualan.Columns.RemoveAt(4);
            tabelPenjualan.Columns.RemoveAt(3);
            tabelPenjualan.Columns.RemoveAt(2);
            tabelPenjualan.Columns.RemoveAt(1);
            tabelPenjualan.Columns.RemoveAt(0);
            LoadSupplierData();

            tabelPenjualan.Update();
            tabelPenjualan.Refresh();

            SetColumnWidth();
        }


        public void SearchPurchase(string query)
        {
            tabelPenjualan.Columns.RemoveAt(9);
            tabelPenjualan.Columns.RemoveAt(8);
            tabelPenjualan.Columns.RemoveAt(7);
            tabelPenjualan.Columns.RemoveAt(6);
            tabelPenjualan.Columns.RemoveAt(5);
            tabelPenjualan.Columns.RemoveAt(4);
            tabelPenjualan.Columns.RemoveAt(3);
            tabelPenjualan.Columns.RemoveAt(2);
            tabelPenjualan.Columns.RemoveAt(1);
            tabelPenjualan.Columns.RemoveAt(0);
            LoadQuerySell(query);

            tabelPenjualan.Update();
            tabelPenjualan.Refresh();

            SetColumnWidth();
        }

        private void LoadQuerySell(string query)
        {

            Database database = Database.getInstance();
            dataSet = database.GetQuerySell(query.ToLower());



            dataSet.Tables[0].Columns.Add("Produk");
            dataSet.Tables[0].Columns.Add("Qty");
            dataSet.Tables[0].Columns.Add("Satuan");
            dataSet.Tables[0].Columns.Add("Harga");
            dataSet.Tables[0].Columns.Add("Diskon");
            dataSet.Tables[0].Columns.Add("Jumlah");

            transList.Clear();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                DataSet newDataSet = database.GetAllRelatedProductSell(dataSet.Tables[0].Rows[i][0].ToString());
                string nl = Environment.NewLine;
                string productList = "";
                string hargaList = "";
                string kuantitasList = "";
                string satuanList = "";
                string diskonList = "";
                string jlhList = "";

                string idTransaksi = dataSet.Tables[0].Rows[i][0].ToString();
                string tujuan = dataSet.Tables[0].Rows[i][1].ToString();
                string id = dataSet.Tables[0].Rows[i][3].ToString();
                string tgl_invoice = dataSet.Tables[0].Rows[i][2].ToString();
                List<Models.Product> list = new List<Models.Product>();

                for (int j = 0; j < newDataSet.Tables[0].Rows.Count; j++)
                {
                    list.Add(new Models.Product(Convert.ToInt32(newDataSet.Tables[0].Rows[j][6].ToString()), newDataSet.Tables[0].Rows[j][0].ToString(), Convert.ToInt32(newDataSet.Tables[0].Rows[j][1].ToString()), newDataSet.Tables[0].Rows[j][2].ToString(), Convert.ToInt32(newDataSet.Tables[0].Rows[j][3].ToString())));

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
                dataSet.Tables[0].Rows[i][4] = productList;
                dataSet.Tables[0].Rows[i][5] = kuantitasList;
                dataSet.Tables[0].Rows[i][6] = satuanList;
                dataSet.Tables[0].Rows[i][7] = hargaList;
                dataSet.Tables[0].Rows[i][8] = diskonList;
                dataSet.Tables[0].Rows[i][9] = jlhList;


                transList.Add(new Models.Transaction(idTransaksi, new Models.Supplier(id, tujuan), tgl_invoice, list));

            }
            dataSet.Tables[0].Columns.RemoveAt(3);
            tabelPenjualan.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tabelPenjualan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            tabelPenjualan.DataSource = dataSet.Tables[0];

        }


        private void setDataGrid()
        {

        }

        public void RefreshReturData()
        {
            RemoveReturColumn();
            LoadReturData();
            SetReturData();
        }

        private void RemoveReturColumn()
        {
            dataGridView1.Columns.Clear();

        }


        private void LoadReturData()
        {
            DataSet ds_ = Database.getInstance().GetAllSellReturn();
            dataSet2 = new DataSet();
            dataSet2.Tables.Add(new DataTable());
            dataSet2.Tables[0].Columns.Add("No Retur");
            dataSet2.Tables[0].Columns.Add("No Invoice");
            dataSet2.Tables[0].Columns.Add("Tanggal");
            dataSet2.Tables[0].Columns.Add("Supplier");
            dataSet2.Tables[0].Columns.Add("Deskripsi");
            dataSet2.Tables[0].Columns.Add("Subtotal");
            for (int i = 0; i < ds_.Tables[0].Rows.Count; i++)
            {
                if (ds_.Tables[0].Rows[i][0].ToString().Length != 0)
                {
                    DataRow dr_ = dataSet2.Tables[0].NewRow();
                    for (int j = 0; j < ds_.Tables[0].Columns.Count; j++)
                    {
                        dr_[j] = ds_.Tables[0].Rows[i][j];
                    }
                    dataSet2.Tables[0].Rows.Add(dr_);
                }
            }
            dataGridView1.DataSource = dataSet2.Tables[0];

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
            dataSet = database.GetAllSell();



            dataSet.Tables[0].Columns.Add("Produk");
            dataSet.Tables[0].Columns.Add("Qty");
            dataSet.Tables[0].Columns.Add("Satuan");
            dataSet.Tables[0].Columns.Add("Harga");
            dataSet.Tables[0].Columns.Add("Diskon");
            dataSet.Tables[0].Columns.Add("Jumlah");

            transList.Clear();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                DataSet newDataSet = database.GetAllRelatedProductSell(dataSet.Tables[0].Rows[i][0].ToString());
                string nl = Environment.NewLine;
                string productList = "";
                string hargaList = "";
                string kuantitasList = "";
                string satuanList = "";
                string diskonList = "";
                string jlhList = "";

                string idTransaksi = dataSet.Tables[0].Rows[i][0].ToString();
                string tujuan = dataSet.Tables[0].Rows[i][1].ToString();
                string id = dataSet.Tables[0].Rows[i][3].ToString();
                string tgl_invoice = dataSet.Tables[0].Rows[i][2].ToString();
                List<Models.Product> list = new List<Models.Product>();

                for (int j = 0; j < newDataSet.Tables[0].Rows.Count; j++)
                {
                    list.Add(new Models.Product(Convert.ToInt32(newDataSet.Tables[0].Rows[j][6].ToString()), newDataSet.Tables[0].Rows[j][0].ToString(), Convert.ToInt32(newDataSet.Tables[0].Rows[j][1].ToString()), newDataSet.Tables[0].Rows[j][2].ToString(), Convert.ToInt32(newDataSet.Tables[0].Rows[j][3].ToString())));

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
                dataSet.Tables[0].Rows[i][4] = productList;
                dataSet.Tables[0].Rows[i][5] = kuantitasList;
                dataSet.Tables[0].Rows[i][6] = satuanList;
                dataSet.Tables[0].Rows[i][7] = hargaList;
                dataSet.Tables[0].Rows[i][8] = diskonList;
                dataSet.Tables[0].Rows[i][9] = jlhList;


                transList.Add(new Models.Transaction(idTransaksi, new Models.Supplier(id, tujuan), tgl_invoice, list));

            }
            dataSet.Tables[0].Columns.RemoveAt(3);
            tabelPenjualan.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tabelPenjualan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            tabelPenjualan.DataSource = dataSet.Tables[0];

        }

        public void UpdatePembelian(int row, Models.Transaction transaction)
        {


            string nl = Environment.NewLine;
            string productList = "";
            string hargaList = "";
            string kuantitasList = "";
            string satuanList = "";
            string diskonList = "";
            string jlhList = "";
            for (int j = 0; j < transaction.produkList.Count; j++)
            {
                transList[row] = transaction;
                if (j == transaction.produkList.Count - 1)
                {
                    productList += transaction.produkList[j].namaProduk;
                    hargaList += transaction.produkList[j].harga;
                    kuantitasList += transaction.produkList[j].jumlah;
                    diskonList += transaction.produkList[j].diskon;
                    jlhList += transaction.produkList[j].jumlah;
                }
                else
                {
                    productList += transaction.produkList[j].namaProduk + nl;
                    hargaList += transaction.produkList[j].harga + nl;
                    kuantitasList += transaction.produkList[j].jumlah + nl;
                    diskonList += transaction.produkList[j].diskon + nl;
                    jlhList += transaction.produkList[j].jumlah + nl;
                }
            }
            dataSet.Tables[0].Rows[row][3] = productList;
            dataSet.Tables[0].Rows[row][2] = transaction.tgl_invoice;
            dataSet.Tables[0].Rows[row][4] = kuantitasList;
            dataSet.Tables[0].Rows[row][6] = hargaList;
            dataSet.Tables[0].Rows[row][7] = diskonList;
            dataSet.Tables[0].Rows[row][8] = jlhList;

        }

        private void SetReturData()
        {
            DataGridViewButtonColumn col1 = new DataGridViewButtonColumn();
            col1.UseColumnTextForButtonValue = true;
            col1.Text = "View Details";
            col1.Name = "Actions";
            dataGridView1.Columns.Add(col1);
            detailBtn += 1;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SetColumnWidth()
        {
            
           
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "View Details";
                col.Name = "Actions";
                tabelPenjualan.Columns.Add(col);
                detailBtn += 1;
        
                
           
            tabelPenjualan.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelPenjualan.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
        }

        public void deleteData(int row)
        {
            transList.RemoveAt(row);
            dataSet.Tables[0].Rows.RemoveAt(row);
            tabelPenjualan.Update();
            tabelPenjualan.Refresh();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search.Text))
            {
                RefreshSellData();
            }
            else
            {
                SearchPurchase(search.Text);
            }
        }

        private void buttonAddPembelian_Click(object sender, EventArgs e)
        {
            Add_Penjualan add_Penjualan= new Add_Penjualan(this);
            add_Penjualan.ShowDialog();
        }

        private void buttonAddPembelian_Click_1(object sender, EventArgs e)
        {
            Add_Penjualan add_Penjualan = new Add_Penjualan(this);
            add_Penjualan.ShowDialog();
        }

        

       

        private void tabelPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 9)
            {
                
                if (e.RowIndex < 0)
                {
                }
                else
                {

                    View_Detail_Penjualan detail_Penjualan = new View_Detail_Penjualan(e.RowIndex, transList[e.RowIndex], this);
                    detail_Penjualan.ShowDialog();
                    //View_Detail_Pembelian view_Detail_Pembelian = new View_Detail_Pembelian(e.RowIndex, transList[e.RowIndex], this);
                    //view_Detail_Pembelian.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0)
                {
                    DataRow dr = dataSet2.Tables[0].Rows[e.RowIndex];
                    Models.ReturTransaksi retur_ = new Models.ReturTransaksi(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString());
                    Retur_Pembelian retur = new Retur_Pembelian(retur_, "RETUR PENJUALAN");
                    retur.ShowDialog();
                }
            }
        }
    }
}
