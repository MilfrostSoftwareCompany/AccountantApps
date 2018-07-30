using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Penjualan : UserControl
    {
        public Penjualan()
        {
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            refreshData();
            tabelPenjualan.RowHeadersVisible = false;
            SetColumnWidth();
        }

        public void refreshData()
        {
            LoadSupplierData();
            tabelPenjualan.Update();
            tabelPenjualan.Refresh();
        }

        private void LoadSupplierData()
        {

            Database database = Database.getInstance();
            DataSet dataSet = database.GetAllSell();

            tabelPenjualan.DataSource = dataSet.Tables[0];
            dataSet.Tables[0].Columns.Add("Produk");
            dataSet.Tables[0].Columns.Add("Qty");
            dataSet.Tables[0].Columns.Add("Satuan");
            dataSet.Tables[0].Columns.Add("Harga");
            dataSet.Tables[0].Columns.Add("Diskon");
            dataSet.Tables[0].Columns.Add("Jumlah");

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
            tabelPenjualan.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tabelPenjualan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "View Details";
            col.Name = "Details";
            tabelPenjualan.Columns.Add(col);

        }

        private void SetColumnWidth()
        {

            tabelPenjualan.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelPenjualan.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPenjualan.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //Console.WriteLine("table pembelian width = " + Convert.ToInt32(tabelPembelian.Width));
            //Console.WriteLine("table pembelian width = " + Convert.ToInt32(tabelPembelian.Width * 0.125));
            //Console.WriteLine("table pembelian width = " + Convert.ToInt32(tabelPembelian.Width * 0.10));
            //tabelPembelian.Columns[0].Width = Convert.ToInt32(tabelPembelian.Width * 0.08);
            //tabelPembelian.Columns[1].Width = Convert.ToInt32(tabelPembelian.Width * 0.125);
            //tabelPembelian.Columns[2].Width = Convert.ToInt32(tabelPembelian.Width * 0.10);
            //tabelPembelian.Columns[3].Width = Convert.ToInt32(tabelPembelian.Width * 0.16);
            //tabelPembelian.Columns[4].Width = Convert.ToInt32(tabelPembelian.Width * 0.18);
            //tabelPembelian.Columns[5].Width = Convert.ToInt32(tabelPembelian.Width * 0.05);
            //tabelPembelian.Columns[6].Width = Convert.ToInt32(tabelPembelian.Width * 0.05);
            //tabelPembelian.Columns[7].Width = Convert.ToInt32(tabelPembelian.Width * 0.10);
            //tabelPembelian.Columns[8].Width = Convert.ToInt32(tabelPembelian.Width * 0.10);
            //tabelPembelian.Columns[9].Width = Convert.ToInt32(tabelPembelian.Width * 0.10);
            //tabelPembelian.Columns[10].Width = Convert.ToInt32(tabelPembelian.Width * 0.10);
        }

        public void InitializeDesign() {
            search.Location = new Point(15, 13);
            buttonSearch.Location = new Point(Convert.ToInt32(search.Width) + 30, 10);
            buttonAddPenjualan.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddPenjualan.Width) - 15, 10);
            tabelPenjualan.Width = Convert.ToInt32(this.Width - 30);
            tabelPenjualan.Height = Convert.ToInt32(this.Height) - Convert.ToInt32(buttonSearch.Height) - 50;
            tabelPenjualan.Location = new Point(15, Convert.ToInt32(buttonSearch.Height) + 30);
        }
        private void button2_Click(object sender, EventArgs e)
        {       
            Add_Penjualan FormAddPenjualan = new Add_Penjualan(this);
            FormAddPenjualan.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi field pencarian !!");
            }
            else
            {

            }
        }
    }
}
