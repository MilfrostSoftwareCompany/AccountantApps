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

        DataSet read;
        int selectedRow = -1;
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
            read = database.getAllSupplierData();
            tabelSupplier.DataSource = read.Tables[0];
        }

        private void SetColumnWidth()
        {
            if (Login.permissionlvl == 1)
            {
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Edit";
                col.Name = "Actions";
                tabelSupplier.Columns.Add(col);

                DataGridViewButtonColumn col1 = new DataGridViewButtonColumn();
                col1.UseColumnTextForButtonValue = true;
                col1.Text = "Delete";
                col1.Name = "Actions";
                tabelSupplier.Columns.Add(col1);
            }
            tabelSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                DataSet ds = Database.getInstance().getAllSupplierData();
                tabelSupplier.DataSource = ds.Tables[0];
                tabelSupplier.Update();
                tabelSupplier.Refresh();
            }
            else
            {
                read = Database.getInstance().getSupplierQuery(search.Text);
                tabelSupplier.DataSource = read.Tables[0];
                tabelSupplier.Update();
                tabelSupplier.Refresh();
            }
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            Add_Supplier FormAddSupplier = new Add_Supplier(this);
            FormAddSupplier.ShowDialog();
        }

        private void tabelSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    selectedRow = e.RowIndex;
                    Models.Supplier supplier = new Models.Supplier(read.Tables[0].Rows[e.RowIndex][0].ToString(), read.Tables[0].Rows[e.RowIndex][1].ToString(), read.Tables[0].Rows[e.RowIndex][2].ToString(), read.Tables[0].Rows[e.RowIndex][3].ToString());
                    Add_Supplier add_Supplier = new Add_Supplier(this, supplier);
                    add_Supplier.ShowDialog();
                }

            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialog = MessageBox.Show("Anda yakin ?", "DELETE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Database.getInstance().DeleteSupplier(read.Tables[0].Rows[e.RowIndex][0].ToString());
                    read.Tables[0].Rows.RemoveAt(e.RowIndex);
                    tabelSupplier.Update();
                    tabelSupplier.Refresh();
                }
            }
        }

        public void AddSupplier(Models.Supplier supplier) {
            DataRow dr = read.Tables[0].NewRow();
            dr[0] = supplier.id;
            dr[1] = supplier.nama;
            dr[2] = supplier.alamat;
            dr[3] = supplier.telepon;

            read.Tables[0].Rows.Add(dr);
            tabelSupplier.Update();
            tabelSupplier.Refresh();
        }
        public void EditSupplier(Models.Supplier supplier) {
            read.Tables[0].Rows[selectedRow][1] = supplier.nama;
            read.Tables[0].Rows[selectedRow][2] = supplier.alamat;
            read.Tables[0].Rows[selectedRow][3] = supplier.telepon;
            tabelSupplier.Update();
            tabelSupplier.Refresh();
        }
    }
}
