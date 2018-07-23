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
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeComponent();
            InitializeDesign();
        }

        public void InitializeDesign() {          
            search.Location = new Point(15,13);
            buttonSearch.Location = new Point(Convert.ToInt32(search.Width)+30,10);
            buttonAddSupplier.Location = new Point( Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddSupplier.Width)-15,10);
            tabelSupplier.Width = Convert.ToInt32(this.Width - 30);
            tabelSupplier.Height = Convert.ToInt32(this.Height)-Convert.ToInt32(buttonSearch.Height)- 50;
            tabelSupplier.Location = new Point(15,Convert.ToInt32(buttonSearch.Height)+30);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Add_Supplier FormAddSupplier = new Add_Supplier(this);
            FormAddSupplier.ShowDialog();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            tabelSupplier.RowHeadersVisible = false;
            LoadSupplierData();
            SetColumnWidth();

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
            //set Weight percentage for each column.
            tabelSupplier.Columns[0].Width = tabelSupplier.Width / 10;
            tabelSupplier.Columns[1].Width = tabelSupplier.Width / 5;
            tabelSupplier.Columns[2].Width = tabelSupplier.Width / 2;
            tabelSupplier.Columns[3].Width = tabelSupplier.Width / 5;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                DataSet ds = Database.getInstance().getSupplierQuery(search.Text);
                tabelSupplier.DataSource = ds.Tables[0];
                tabelSupplier.Update();
                tabelSupplier.Refresh();
            }
        }
    }
}
