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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi field pencarian !!");
            }
            else
            {

            }
        }

        private void buttonAddProduk_Click(object sender, EventArgs e)
        {
            Add_Produk FormAddProduk = new Add_Produk(this);
            FormAddProduk.ShowDialog();
        }

        private void buttonOpnameStock_Click(object sender, EventArgs e)
        {
            Opname_Stock FormOpnameStock = new Opname_Stock();
            FormOpnameStock.ShowDialog();
        }
    }
}
