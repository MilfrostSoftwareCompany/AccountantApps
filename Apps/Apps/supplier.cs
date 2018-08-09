using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Apps
{
    public partial class Supplier : UserControl
    {


        public Supplier()
        {
            InitializeComponent();
            this.Width = Home.widthPanel;
            //this.Height = Home.heightPanel;
            InitializeDesign();
            tabelSupplier.RowHeadersVisible = false;
            LoadSupplierData();
            SetColumnWidth();
        }

        public void InitializeDesign()
        {
            //tabelSupplier.AutoSize = false;
            //search.Location = new Point(15,13);
            //buttonSearch.Location = new Point(Convert.ToInt32(search.Width)+30,10);
            //buttonAddSupplier.Location = new Point( Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddSupplier.Width)-15,10);
            //tabelSupplier.Width = Convert.ToInt32(this.Width - 30);
            //tabelSupplier.Height = Convert.ToInt32(this.Height)-Convert.ToInt32(buttonSearch.Height)- 50;
            //tabelSupplier.Location = new Point(15,Convert.ToInt32(buttonSearch.Height)+30);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            

        }

        public void refreshData()
        {
            LoadSupplierData();
            tabelSupplier.Update();
            tabelSupplier.Refresh();
        }

        private void LoadSupplierData()
        {
            Database database = Database.getInstance();
            DataSet read = database.getAllSupplierData();
            tabelSupplier.DataSource = read.Tables[0];
        }

        private void SetColumnWidth()
        {
            tabelSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi field pencarian !!");
            }
            else
            {
                DataSet ds = Database.getInstance().getSupplierQuery(search.Text);
                tabelSupplier.DataSource = ds.Tables[0];
                tabelSupplier.Update();
                tabelSupplier.Refresh();
            }
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            Add_Supplier FormAddSupplier = new Add_Supplier(this);
            FormAddSupplier.ShowDialog();
        }
    }
}
