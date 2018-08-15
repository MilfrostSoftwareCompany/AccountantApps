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

        DataSet read;
        int selectedRow = -1;

        public Customer()
        {
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeComponent();
            InitializeDesign();
            search.Focus();
            tabelCustomer.RowHeadersVisible = false;
            LoadCustomerData();
            SetColumnWidth();
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
            read = database.getAllCustomerData();
            tabelCustomer.DataSource = read.Tables[0];
        }

        private void SetColumnWidth()
        {
            //set Weight percentage for each column.
            if (Login.permissionlvl == 1)
            {
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Edit";
                col.Name = "Actions";
                tabelCustomer.Columns.Add(col);

                DataGridViewButtonColumn col1 = new DataGridViewButtonColumn();
                col1.UseColumnTextForButtonValue = true;
                col1.Text = "Delete";
                col1.Name = "Actions";
                tabelCustomer.Columns.Add(col1);
            }
            tabelCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void tabelCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    selectedRow = e.RowIndex;
                    Models.Customer customer = new Models.Customer(read.Tables[0].Rows[e.RowIndex][0].ToString(), read.Tables[0].Rows[e.RowIndex][1].ToString(), read.Tables[0].Rows[e.RowIndex][2].ToString(), read.Tables[0].Rows[e.RowIndex][3].ToString());
                    Add_Customer addCust = new Add_Customer(this, customer);
                    addCust.ShowDialog();
                }
            }

            else if (e.ColumnIndex == 1)
            {
                DialogResult dialog = MessageBox.Show("Anda yakin ?", "DELETE DATA", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Database.getInstance().DeleteSupplier(read.Tables[0].Rows[e.RowIndex][0].ToString());
                    read.Tables[0].Rows.RemoveAt(e.RowIndex);
                    tabelCustomer.Update();
                    tabelCustomer.Refresh();
                }
                
            }
        }

        public void AddCustomer(Models.Customer cust)
        {
            DataRow dr = read.Tables[0].NewRow();
            dr[0] = cust.id;
            dr[1] = cust.nama;
            dr[2] = cust.alamat;
            dr[3] = cust.telepon;

            read.Tables[0].Rows.Add(dr);
            tabelCustomer.Update();
            tabelCustomer.Refresh();
        }
        public void EditCustomer(Models.Customer cust)
        {
            read.Tables[0].Rows[selectedRow][1] = cust.nama;
            read.Tables[0].Rows[selectedRow][2] = cust.alamat;
            read.Tables[0].Rows[selectedRow][3] = cust.telepon;
            tabelCustomer.Update();
            tabelCustomer.Refresh();
        }

    }
}
