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
    public partial class Add_Barang : Form
    {

        Models.Product selectedProduct;
        Form caller;
        DataSet ds;
        bool isEditDetail = false;
        List<Models.Product> addedList = new List<Models.Product>();
        List<Models.Product> removedList = new List<Models.Product>();

        public Add_Barang(Form caller,List<Models.Product> productList)
        {
            this.caller = caller;
            InitializeComponent();

            this.comboBox1.SelectedIndexChanged +=
            new System.EventHandler(ComboBox1_SelectedIndexChanged);
            RetrieveData(productList);
        }

        public Add_Barang(Form caller, List<Models.Product> addedProduct, List<Models.Product> deletedProduct) {
            this.caller = caller;
            this.addedList = addedProduct;
            this.removedList = deletedProduct;
            InitializeComponent();

            isEditDetail = true;

            this.comboBox1.SelectedIndexChanged +=
            new System.EventHandler(ComboBox1_SelectedIndexChanged);
            RetrieveData();
        }

        public Add_Barang(Form caller)
        {
            this.caller = caller;
            InitializeComponent();

            this.comboBox1.SelectedIndexChanged +=
            new System.EventHandler(ComboBox1_SelectedIndexChanged);
            RetrieveData();
        }

        private void RetrieveData()
        {
            
            ds = Database.getInstance().GetAllProducts();
            comboBox1.DataSource = ds.Tables[0];
            if (isEditDetail) {
                if (caller is View_Detail_Pembelian)
                {

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < addedList.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() == addedList[j].idProduk.ToString())
                            {
                                ds.Tables[0].Rows[i][2] = Convert.ToInt32(ds.Tables[0].Rows[i][2]) - addedList[j].jumlah;
                                break;
                            }
                        }

                    }
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < removedList.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() == removedList[j].idProduk.ToString())
                            {
                                ds.Tables[0].Rows[i][2] = Convert.ToInt32(ds.Tables[0].Rows[i][2]) + removedList[j].jumlah;
                                break;
                            }
                        }

                    }
                }
                else if (caller is View_Detail_Penjualan) {

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < addedList.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() == addedList[j].idProduk.ToString())
                            {
                                ds.Tables[0].Rows[i][2] = Convert.ToInt32(ds.Tables[0].Rows[i][2]) + addedList[j].jumlah;
                                break;
                            }
                        }

                    }
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < removedList.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() == removedList[j].idProduk.ToString())
                            {
                                ds.Tables[0].Rows[i][2] = Convert.ToInt32(ds.Tables[0].Rows[i][2]) - removedList[j].jumlah;
                                break;
                            }
                        }

                    }
                }
            }
            comboBox1.DisplayMember = "Nama Produk";
            comboBox1.ValueMember = "ID";
            setView(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
        }


        private void RetrieveData(List<Models.Product> list)
        {
            ds = new DataSet();
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("ID");
            ds.Tables[0].Columns.Add("Nama Produk");
            ds.Tables[0].Columns.Add("Jumlah");
            ds.Tables[0].Columns.Add("Satuan");
            ds.Tables[0].Columns.Add("Harga");
            ds.Tables[0].Columns.Add("Diskon");
            ds.Tables[0].Columns.Add("Subtotal");

            for (int i=0;i<list.Count;i++) {

                DataRow dataRow = ds.Tables[0].NewRow();
                dataRow[0] = list[i].idProduk;
                dataRow[1] = list[i].namaProduk;
                dataRow[2] = list[i].jumlah;
                dataRow[3] = list[i].jenisSatuan;
                dataRow[4] = list[i].harga;
                dataRow[5] = list[i].diskon;
                dataRow[6] = list[i].getTotal();
                ds.Tables[0].Rows.Add(dataRow);
            }

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Nama Produk";
            comboBox1.ValueMember = "ID";
            if (list.Count != 0)
            {
                setView(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
            }
        }

        private void setView(int id) {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                if (Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()) == id) {
                    //set views
                    label2.Text = ds.Tables[0].Rows[i][1].ToString();
                    label3.Text = "Rp. " +ds.Tables[0].Rows[i][4].ToString();
                    label4.Text = "Stock = " + ds.Tables[0].Rows[i][2].ToString();

                    if (jlhBarang.Value > Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString())) {
                        jlhBarang.Value = Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString());
                        
                    }
                    jlhBarang.Maximum = Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString());

                    break;
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;

            int id = Convert.ToInt32 (comboBox1.SelectedValue);
            setView(id);
        }

        private void buttonAddBarang_Click(object sender, EventArgs e)
        {
            selectedProduct = new Models.Product(Convert.ToInt32(comboBox1.SelectedValue), label2.Text, Convert.ToInt32(jlhBarang.Text), ds.Tables[0].Rows[comboBox1.SelectedIndex][3].ToString(), Convert.ToInt32(ds.Tables[0].Rows[comboBox1.SelectedIndex][4].ToString()));
            if (caller is Add_Pembelian)
            {
                Add_Pembelian add_Pembelian = (Add_Pembelian)caller;
                add_Pembelian.AddProdukToTable(selectedProduct);
            }
            else if (caller is Add_Penjualan)
            {
                Add_Penjualan add_Penjualan = (Add_Penjualan)caller;
                add_Penjualan.AddProdukToTable(selectedProduct);
            }
            else if (caller is View_Detail_Pembelian)
            {
                View_Detail_Pembelian view_Detail = (View_Detail_Pembelian)caller;
                view_Detail.addProduk(selectedProduct);
            }
            else if(caller is View_Detail_Penjualan)
            {
                View_Detail_Penjualan view_Detail_Penjualan = (View_Detail_Penjualan)caller;
                view_Detail_Penjualan.addProduk(selectedProduct);

            }
            else if (caller is Retur_Pembelian) {
                Retur_Pembelian retur = (Retur_Pembelian)caller;
                retur.AddProduct(selectedProduct);
            }
            this.Close();
        }
    }
}
