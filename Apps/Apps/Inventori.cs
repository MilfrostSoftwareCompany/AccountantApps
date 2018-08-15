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
    public partial class Inventori : UserControl
    {
        DataSet ds;
        public Inventori()
        {
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeComponent();
            RetrieveData();
            InitDataGrid();
            
            //InitializeDesign();
            search.Focus();
        }

        private void InitDataGrid()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "View Details";
            col.Name = "Actions";
            tabelInventori.Columns.Add(col);
            if (Login.permissionlvl == 1)
            {
                DataGridViewButtonColumn del = new DataGridViewButtonColumn();
                del.UseColumnTextForButtonValue = true;
                del.Text = "Delete";
                del.Name = "Actions";
                tabelInventori.Columns.Add(del);
            }
            tabelInventori.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelInventori.RowHeadersVisible = false;
        }

        private void RetrieveData() {
            ds = Database.getInstance().GetAllProducts();
            tabelInventori.DataSource = ds.Tables[0];
        }

        public void RefreshData()
        {
            RetrieveData();
            tabelInventori.Update();
            tabelInventori.Refresh();

        }

        public void InitializeDesign()
        {
            search.Location = new Point(15, 13);
            buttonSearch.Location = new Point(Convert.ToInt32(search.Width) + 30, 10);
            buttonAddProduk.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddProduk.Width) - 15, 10);
            buttonOpnameStock.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonOpnameStock.Width) - 15,Convert.ToInt32(buttonAddProduk.Height) + 20);
            tabelInventori.Width = Convert.ToInt32(this.Width - 30);
            tabelInventori.Height = Convert.ToInt32(this.Height) - Convert.ToInt32(buttonAddProduk.Height) - Convert.ToInt32(buttonOpnameStock.Height) - 80;
            tabelInventori.Location = new Point(15, Convert.ToInt32(buttonAddProduk.Height)+Convert.ToInt32(buttonOpnameStock.Height) + 45);
        }

        private void RemoveColumns()
        {
            tabelInventori.Columns.RemoveAt(6);
            tabelInventori.Columns.RemoveAt(5);
            tabelInventori.Columns.RemoveAt(4);
            tabelInventori.Columns.RemoveAt(3);
            tabelInventori.Columns.RemoveAt(2);
            tabelInventori.Columns.RemoveAt(1);
            tabelInventori.Columns.RemoveAt(0);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                RemoveColumns();
                RefreshData();

            }
            else
            {
                RemoveColumns();
                ds = Database.getInstance().GetQueryProduct(search.Text);
                tabelInventori.DataSource = ds.Tables[0];
                tabelInventori.Update();
                tabelInventori.Refresh();
            }

            tabelInventori.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "View Details";
            col.Name = "Actions";
            tabelInventori.Columns.Add(col);
            if (Login.permissionlvl == 1)
            {
                DataGridViewButtonColumn del = new DataGridViewButtonColumn();
                del.UseColumnTextForButtonValue = true;
                del.Text = "Delete";
                del.Name = "Actions";
                tabelInventori.Columns.Add(del);
            }
        }

        private void buttonAddProduk_Click(object sender, EventArgs e)
        {
            Add_Produk FormAddProduk = new Add_Produk(this);
            FormAddProduk.ShowDialog();
        }

        private void buttonOpnameStock_Click(object sender, EventArgs e)
        {
            List_Opname_Stock list = new List_Opname_Stock(this);
            list.ShowDialog();
            
        }

        private void DeleteProduct(int row)
        {
            
            Database.getInstance().DeleteProduct(ds.Tables[0].Rows[row][0].ToString());
            ds.Tables[0].Rows.RemoveAt(row);
            tabelInventori.Update();
            tabelInventori.Refresh();
        }

        private void tabelInventori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

            if (e.ColumnIndex == 0 && e.RowIndex >= 0) {
                Models.Product product = new Models.Product(ds.Tables[0].Rows[e.RowIndex]);
                Add_Produk add_Produk = new Add_Produk(this,product);
                add_Produk.ShowDialog();
            }
            if (e.ColumnIndex == 1 && e.RowIndex >= 0) {
                DeleteProduct(e.RowIndex);
            }
        }
    }
}
