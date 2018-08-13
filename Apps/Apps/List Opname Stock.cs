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
    public partial class List_Opname_Stock : Form
    {

        DataSet ds;
        List<Models.Opname> list = new List<Models.Opname>();
        Inventori inventori;
        public List_Opname_Stock(Inventori inventori)
        {
            InitializeComponent();
            GetOpnameData();
            this.inventori = inventori;
        }

        public void AddOpname(Models.Opname opname) {
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = opname.idOpname;
            dr[1] = opname.startDate;
            dr[2] = opname.endDate;
            dr[3] = opname.doneBy;

            string produk = "";
            string jumlah = "";
            string nl = Environment.NewLine;

            for (int i = 0; i < opname.product.Count;i++) {
                if (i == opname.product.Count - 1)
                {
                    produk += opname.product[i].namaProduk;
                    jumlah += opname.jumlah[i];
                }
                else
                {
                    produk += opname.product[i].namaProduk + nl;
                    jumlah += opname.jumlah[i] + nl;
                }
            }
            dr[4] = produk;
            dr[5] = jumlah;

            ds.Tables[0].Rows.Add(dr);
            dataGridView1.Update();
            dataGridView1.Refresh();

            inventori.RefreshData();
        }

        private void GetOpnameData() {
            ds = Database.getInstance().GetOpnameData();
            ds.Tables[0].Columns.Add("Produk");
            ds.Tables[0].Columns.Add("Jumlah");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {


                int idOpname = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                string startDate = ds.Tables[0].Rows[i][1].ToString();
                string endDate = ds.Tables[0].Rows[i][2].ToString();
                List<Models.Product> produkList = new List<Models.Product>();
                List<int> jlhList = new List<int>();
                string doneBy = ds.Tables[0].Rows[i][3].ToString();

                Models.Opname opname = new Models.Opname(idOpname, startDate, endDate, produkList, jlhList, doneBy);

                DataSet newDs = Database.getInstance().GetOpnameDetails(ds.Tables[0].Rows[i][0].ToString());
                string nl = Environment.NewLine;
                string produk = "";
                string jumlah = "";
                for (int j = 0; j < newDs.Tables[0].Rows.Count; j++) {
                    opname.product.Add(new Models.Product(Convert.ToInt32(newDs.Tables[0].Rows[j][0].ToString()), newDs.Tables[0].Rows[j][1].ToString(), Convert.ToInt32(newDs.Tables[0].Rows[j][2].ToString())));
                    if (j == newDs.Tables[0].Rows.Count - 1)
                    {
                        produk += newDs.Tables[0].Rows[j][1].ToString();
                        jumlah += newDs.Tables[0].Rows[j][2].ToString();
                    }
                    else {
                        produk += newDs.Tables[0].Rows[j][1].ToString() + nl;
                        jumlah += newDs.Tables[0].Rows[j][2].ToString() + nl;
                    }
                }
                list.Add(opname);
                ds.Tables[0].Rows[i][4] = produk;
                ds.Tables[0].Rows[i][5] = jumlah;
            }
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.RowHeadersVisible = false;
        }

        private void buttonAddOpnameStock_Click(object sender, EventArgs e)
        {
            Opname_Stock FormOpnameStock = new Opname_Stock(this);
            FormOpnameStock.ShowDialog();
        }
    }
}
