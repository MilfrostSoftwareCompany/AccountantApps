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
            search.Focus();
        }

        public void InitializeDesign()
        {
            //search.Location = new Point(15, 13);
            //buttonSearch.Location = new Point(Convert.ToInt32(search.Width) + 30, 10);
            //buttonAddCustomer.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddCustomer.Width) - 15, 10);
            //tabelCustomer.Width = Convert.ToInt32(this.Width - 30);
            //tabelCustomer.Height = Convert.ToInt32(this.Height) - Convert.ToInt32(buttonSearch.Height) - 50;
            //tabelCustomer.Location = new Point(15, Convert.ToInt32(buttonSearch.Height) + 30);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi field pencarian !!");
            }
            else
            {
                DataSet ds = Database.getInstance().getQueryCustomer(search.Text);
                tabelCustomer.DataSource = ds.Tables[0];
                tabelCustomer.Update();
                tabelCustomer.Refresh();
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Add_Customer FormAddCustomer = new Add_Customer(this);
            FormAddCustomer.ShowDialog();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            tabelCustomer.RowHeadersVisible = false;
            LoadCustomerData();
            SetColumnWidth();           
        }

        public void refreshData()
        {
            LoadCustomerData();
            tabelCustomer.Update();
            tabelCustomer.Refresh();
        }

        private void LoadCustomerData()
        {
            Database database = Database.getInstance();
            DataSet read = database.getAllCustomerData();
            tabelCustomer.DataSource = read.Tables[0];
        }

        private void SetColumnWidth()
        {
            //set Weight percentage for each column.
            tabelCustomer.Columns[0].Width = tabelCustomer.Width / 10;
            tabelCustomer.Columns[1].Width = tabelCustomer.Width / 5;
            tabelCustomer.Columns[2].Width = tabelCustomer.Width / 2;
            tabelCustomer.Columns[3].Width = tabelCustomer.Width / 5;
        }
    }
}
