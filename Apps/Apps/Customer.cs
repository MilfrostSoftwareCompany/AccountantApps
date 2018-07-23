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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeComponent();
            InitializeDesign();
        }
<<<<<<< HEAD
        public void InitializeDesign()
        {
            search.Location = new Point(15, 13);
            buttonSearch.Location = new Point(Convert.ToInt32(search.Width) + 30, 10);
            buttonAddCustomer.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddCustomer.Width) - 15, 10);
            tabelCustomer.Width = Convert.ToInt32(this.Width - 30);
            tabelCustomer.Height = Convert.ToInt32(this.Height) - Convert.ToInt32(buttonSearch.Height) - 50;
            tabelCustomer.Location = new Point(15, Convert.ToInt32(buttonSearch.Height) + 30);
=======

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Customer FormAddCustomer = new Add_Customer(this);
            FormAddCustomer.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Add_Customer FormAddCustomer = new Add_Customer(this);
            FormAddCustomer.ShowDialog();
>>>>>>> da2cbba3b16907ee4d47f31052f9b5d9a9f5aba3
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0 )
            {
                MessageBox.Show("Harus mengisi field pencarian !!");
            }
            else
            {
                DataSet ds = Database.getInstance().getQueryCustomer(search.Text);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }
<<<<<<< HEAD
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Add_Customer FormAddCustomer = new Add_Customer();
            FormAddCustomer.ShowDialog();
=======

        private void Customer_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            LoadCustomerData();
            SetColumnWidth();

        }

        public void refreshData()
        {
            LoadCustomerData();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void LoadCustomerData()
        {
            Database database = Database.getInstance();
            DataSet read = database.getAllCustomerData();
            dataGridView1.DataSource = read.Tables[0];
        }

        private void SetColumnWidth()
        {
            //set Weight percentage for each column.
            dataGridView1.Columns[0].Width = dataGridView1.Width / 10;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 5;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 2;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 5;

>>>>>>> da2cbba3b16907ee4d47f31052f9b5d9a9f5aba3
        }
    }
}
