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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Pembelian FormAddPembelian = new Add_Pembelian();
            FormAddPembelian.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Pembelian_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            LoadSupplierData();
            SetColumnWidth();

        }

        public void refreshData()
        {
            LoadSupplierData();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void LoadSupplierData()
        {
            Database database = Database.getInstance();
            DataSet dataSet = database.GetAllPurchase();
            
            dataGridView1.DataSource = dataSet.Tables[0];
            dataSet.Tables[0].Columns.Add("Produk");
            dataSet.Tables[0].Columns.Add("Qty");
            dataSet.Tables[0].Columns.Add("Satuan");
            dataSet.Tables[0].Columns.Add("Harga");
            dataSet.Tables[0].Columns.Add("Diskon");
            dataSet.Tables[0].Columns.Add("Jumlah");

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                DataSet newDataSet = database.GetAllRelatedProductPurchase(dataSet.Tables[0].Rows[i][0].ToString());
                string nl = Environment.NewLine;
                string productList = "";
                string hargaList = "";
                string kuantitasList = "";
                string satuanList = "";
                string diskonList = "";
                string jlhList = "";
                for (int j = 0; j < newDataSet.Tables[0].Rows.Count; j++) {
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
            }
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "View Details";
            col.Name = "Details";
            dataGridView1.Columns.Add(col);
        }

        private void SetColumnWidth()
        {

            dataGridView1.Columns[0].Width = dataGridView1.Width /12;
            dataGridView1.Columns[1].Width = dataGridView1.Width /10;
            dataGridView1.Columns[2].Width = dataGridView1.Width /10;
            dataGridView1.Columns[3].Width = dataGridView1.Width /10;
            dataGridView1.Columns[4].Width = dataGridView1.Width /8;
            dataGridView1.Columns[5].Width = dataGridView1.Width /20;
            dataGridView1.Columns[6].Width = dataGridView1.Width /20;
            dataGridView1.Columns[7].Width = dataGridView1.Width /10;
            dataGridView1.Columns[8].Width = dataGridView1.Width /10;
            dataGridView1.Columns[9].Width = dataGridView1.Width / 10;
            dataGridView1.Columns[9].Width = dataGridView1.Width / 10;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

    }
}
