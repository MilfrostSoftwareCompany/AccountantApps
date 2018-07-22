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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Supplier FormAddSupplier = new Add_Supplier();
            FormAddSupplier.ShowDialog();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            LoadSupplierData();
            SetColumnWidth();

        }

        private void LoadSupplierData()
        {
            Database database = Database.getInstance();
            DataSet read = database.getAllSupplierData();
            dataGridView1.DataSource = read.Tables[0];
        }

        private void SetColumnWidth()
        {
            //set Weight percentage for each column.
            dataGridView1.Columns[0].Width = dataGridView1.Width / 10;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 5;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 2;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 5;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text.Length != 0)
            {
                DataSet ds = Database.getInstance().getSupplierQuery(search.Text);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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
