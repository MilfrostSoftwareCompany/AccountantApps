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
    public partial class AddOpnameProduk : Form
    {
        Opname_Stock opname;
        DataSet ds;
        public AddOpnameProduk( Opname_Stock opname)
        {
            this.opname = opname;
            InitializeComponent();
            RetrieveData();
        }

        private void RetrieveData()
        {

            ds = Database.getInstance().GetAllProducts();
            produkList.DataSource = ds.Tables[0];
            produkList.DisplayMember = "Nama Produk";
            produkList.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                if (ds.Tables[0].Rows[i][0].ToString() == produkList.SelectedValue.ToString()) {
                    
                    DataRow dataRow = ds.Tables[0].Rows[i];
                    Models.Product product = new Models.Product(Convert.ToInt32(dataRow[0].ToString()), dataRow[1].ToString(), Convert.ToInt32(dataRow["Stock"].ToString()), dataRow[3].ToString(), Convert.ToInt32(dataRow[4].ToString()));
                    opname.AddProduct(product, Convert.ToInt32(jlhBarang.Value));

                }
            }
            
        }
    }
}
