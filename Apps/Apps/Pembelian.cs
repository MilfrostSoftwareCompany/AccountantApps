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
            tabelPembelian.Update();
            tabelPembelian.Refresh();
        }

        private void LoadSupplierData()
        {

            Database database = Database.getInstance();
            DataSet dataSet = database.GetAllPurchase();

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

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "View Details";
            col.Name = "Details";
            tabelPembelian.Columns.Add(col);

        }

        private void SetColumnWidth()
        {

            tabelPembelian.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelPembelian.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tabelPembelian.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
    }
}
