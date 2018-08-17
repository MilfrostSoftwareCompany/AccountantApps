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
    public partial class Add_Penjualan : Form
    {
        DataSet custDs;
        DataSet ds;
        DataSet companyDs;
        Penjualan penjualan;
        Apps.Models.Supplier idCustomer;
        List<Apps.Models.Product> produkList = new List<Models.Product>();
        List<Apps.Models.Customer> customerList = new List<Models.Customer>();

        
       

        public Add_Penjualan(Penjualan penjualan)
        {

            InitializeComponent();
            this.penjualan = penjualan;
            retrieveData();
            ds = new DataSet();
            initDataSource();
            initDataGrid();
            dataGridView1.RowHeadersVisible = false;

            companyDs = Database.getInstance().GetCompanyDetails();
            namaToko.Text = companyDs.Tables[0].Rows[0][1].ToString();
            wilayahToko.Text = companyDs.Tables[0].Rows[0][2].ToString();

            
        }

        private void retrieveData()
        {
            custDs = Database.getInstance().getAllCustomerData();
            comboBox1.DataSource = custDs.Tables[0];
            comboBox1.DisplayMember = "Nama";
            comboBox1.ValueMember = "ID";
        }
        private void initDataGrid()
        {
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            dataGridView1.Columns.Add(col);
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            setDetailsChange(e.RowIndex);
        }

        private void setDetailsChange(int row)
        {
            //update data
            produkList[row].jumlah = Convert.ToInt32(ds.Tables[0].Rows[row][2].ToString());
            produkList[row].harga = Convert.ToInt32(ds.Tables[0].Rows[row][5].ToString());
            produkList[row].diskon = Convert.ToInt32(ds.Tables[0].Rows[row][6].ToString());
            ds.Tables[0].Rows[row][7] = (produkList[row].harga * produkList[row].jumlah) - produkList[row].diskon;

            subtotal.Text = "Rp. " + calculateSubtotal();
            disc.Text = "Rp. " + calculateDisc();
            total.Text = "Rp. " + calculateTotal();


        }

        private void initDataSource()
        {
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("No.");
            ds.Tables[0].Columns.Add("ID Produk");
            ds.Tables[0].Columns.Add("Jlh");
            ds.Tables[0].Columns.Add("Satuan");
            ds.Tables[0].Columns.Add("Nama Produk");
            ds.Tables[0].Columns.Add("Harga");
            ds.Tables[0].Columns.Add("Diskon");
            ds.Tables[0].Columns.Add("Total");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private int calculateSubtotal()
        {
            int sub = 0;
            foreach (Models.Product pro in produkList)
            {
                sub += (pro.jumlah * pro.harga);
            }
            return sub;
        }

        private int calculateDisc()
        {
            int sub = 0;
            foreach (Models.Product pro in produkList)
            {
                sub += pro.diskon;
            }
            return sub;
        }
        private int calculateTotal()
        {
            int sub = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sub += Convert.ToInt32(ds.Tables[0].Rows[i][7]);
            }
            return sub;
        }

        private void refreshCalculation()
        {
            subtotal.Text = "Rp. " + calculateSubtotal();
            disc.Text = "Rp. " + calculateDisc();
            total.Text = "Rp. " + calculateTotal();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(noFaktur.Text) && !string.IsNullOrWhiteSpace(tglInvoice.Text) && produkList.Count != 0)
            {
                string dbDate = DateTime.Parse(tglInvoice.Text).ToString("yyyy-MM-dd");
                idCustomer = new Models.Supplier(custDs.Tables[0].Rows[comboBox1.SelectedIndex]);
                Apps.Models.Transaction transaction = new Models.Transaction(noFaktur.Text, idCustomer, dbDate, produkList);
                Console.WriteLine(idCustomer.id);
                if (Database.getInstance().IsSellExist(transaction.invoice_no) == 0)
                {
                    if (Database.getInstance().CreateNewSell(transaction))
                    {

                        MessageBox.Show("Data Pembelian telah ditambahkan");

                    }
                    penjualan.addData(transaction);
                    MessageBox.Show("Data Penjualan telah di tambahkan");
                    this.Close();
                }
                else {
                    MessageBox.Show("Gunakan No.Invoice Baru");
                }
            }
            else if (string.IsNullOrWhiteSpace(noFaktur.Text))
            {
                MessageBox.Show("Masukkan Invoice No.");
            }
            else if (produkList.Count == 0)
            {
                MessageBox.Show("Masukkan Produk");
            }
        }

        int countItem = 0;
        private void buttonAddBarang_Click(object sender, EventArgs e)
        {
            if (countItem < 7)
            {
                if (countItem == 6)
                {
                    buttonAddBarang.Visible = false;
                }
                Add_Barang FormAddBarang = new Add_Barang(this);
                FormAddBarang.ShowDialog();
                countItem++;
                refreshCalculation();
            }
            MessageBox.Show("Data Barang telah di tambahkan");
        }

        public void AddProdukToTable(Models.Product product)
        {

            int found = -1;

            for (int i = 0; i < produkList.Count; i++)
            {
                if (produkList[i].idProduk == product.idProduk)
                {
                    found = i;
                    break;
                }
            }

            if (found == -1)
            {

                produkList.Add(product);


                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = ds.Tables[0].Rows.Count;
                dr[1] = product.idProduk;
                dr[2] = product.jumlah;
                dr[3] = product.jenisSatuan;
                dr[4] = product.namaProduk;
                dr[5] = product.harga;
                dr[6] = product.diskon;
                dr[7] = (product.harga * product.jumlah) - product.diskon;

                ds.Tables[0].Rows.Add(dr);
            }
            else
            {
                produkList[found].jumlah += product.jumlah;
                ds.Tables[0].Rows[found][2] = produkList[found].jumlah;
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("index = " + e.ColumnIndex);
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Produk telah dihapus");
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                produkList.RemoveAt(e.RowIndex);
            }
        }

        private void noFaktur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tglInvoice.Focus();
            }
        }

        private void tglInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddBarang.Focus();
            }
        }
    }
}
