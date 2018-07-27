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
            textBox1.Text = "0";
            ds = Database.getInstance().GetAllProducts();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Nama Produk";
            comboBox1.ValueMember = "ID";
            setView(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
        }

        private void setView(int id) {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                if (Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()) == id) {
                    //set views
                    label2.Text = ds.Tables[0].Rows[i][1].ToString();
                    label3.Text = "Rp. " +ds.Tables[0].Rows[i][4].ToString();
                    label4.Text = "Stock = " + ds.Tables[0].Rows[i][2].ToString();
                    selectedProduct = new Models.Product(id, label2.Text, Convert.ToInt32(textBox1.Text), ds.Tables[0].Rows[i][3].ToString(), Convert.ToInt32(ds.Tables[0].Rows[i][4].ToString()));
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
            if (caller is Add_Pembelian)
            {
                Add_Pembelian add_Pembelian = (Add_Pembelian)caller;
                add_Pembelian.AddProdukToTable(selectedProduct);
            }
            else if (caller is Add_Penjualan) {

            }
        }
    }
}
