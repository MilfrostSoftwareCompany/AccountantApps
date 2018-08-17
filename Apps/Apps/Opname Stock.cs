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
    public partial class Opname_Stock : Form
    {
        List_Opname_Stock list_Opname_Stock;
        List<Models.Product> productList = new List<Models.Product>();
        List<int> jumlah = new List<int>();
        DataSet ds = new DataSet();
        public Opname_Stock(List_Opname_Stock list_Opname_Stock)
        {
            this.list_Opname_Stock = list_Opname_Stock;
            InitializeComponent();
            //InitializeDesign();
            InitDataGridView();
            DariTgl.Focus();

        }

        private void InitDataGridView() {
            tabelOpname.RowHeadersVisible = false;
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("ID");
            ds.Tables[0].Columns.Add("Nama Produk");
            ds.Tables[0].Columns.Add("Stok Terdata");
            ds.Tables[0].Columns.Add("Stok Gudang");
            tabelOpname.DataSource = ds.Tables[0];
            tabelOpname.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Delete";
            tabelOpname.Columns.Add(col);
        }

        public void InitializeDesign()
        {
            labelDariTgl.Location = new Point(15, 15);
            DariTgl.Location = new Point(Convert.ToInt32(labelDariTgl.Width)+55, 13);
            labelSampaiTgl.Location = new Point(15, Convert.ToInt32(labelDariTgl.Height)+30);
            SampaiTgl.Location = new Point(Convert.ToInt32(labelSampaiTgl.Width) + 30, Convert.ToInt32(labelDariTgl.Height) + 30);
            buttonAddProduk.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddProduk.Width) - 30, Convert.ToInt32(labelDariTgl.Height) + 30);
            //buttonSave.Location = new Point(Convert.ToInt32(this.Width)-Convert.ToInt32(buttonSave.Width)-30,Convert.ToInt32(this.Height)-Convert.ToInt32(buttonSave.Height)-45);
            tabelOpname.Width = Convert.ToInt32(this.Width) - 45;
            //tabelOpname.Height = Convert.ToInt32(this.Height) - Convert.ToInt32(labelDariTgl.Height) - Convert.ToInt32(labelSampaiTgl.Height)-Convert.ToInt32(buttonSave.Height) - 105;
            tabelOpname.Location = new Point(15, Convert.ToInt32(labelDariTgl.Height) + Convert.ToInt32(labelSampaiTgl.Height)+ 45);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (DariTgl.Text.Length == 0 || SampaiTgl.Text.Length == 0 || textBox1.Text.Length==0||productList.Count==0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
                if (DariTgl.Text.Length == 0) { DariTgl.Focus(); }
                else { SampaiTgl.Focus(); }
            }
            else
            {
                string startDate = DateTime.Parse(DariTgl.Text).ToString("yyyy-MM-dd");
                string endDate = DateTime.Parse(SampaiTgl.Text).ToString("yyyy-MM-dd");
                Models.Opname opname = new Models.Opname(startDate, endDate, productList, jumlah, textBox1.Text);
                Database.getInstance().OpnameBaru(opname,false);
                this.Close();
            }
        }

        private void buttonAddProduk_Click(object sender, EventArgs e)
        {
            AddOpnameProduk addOpnameProduk = new AddOpnameProduk(this);
            addOpnameProduk.ShowDialog();
            //Add_Produk FormAddProduk = new Add_Produk();
            //FormAddProduk.ShowDialog();
        }

        public void AddProduct(Models.Product product, int stokGudang) {
            productList.Add(product);
            jumlah.Add(stokGudang);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = product.idProduk;
            dr[1] = product.namaProduk;
            dr[2] = product.jumlah;
            dr[3] = stokGudang;

            ds.Tables[0].Rows.Add(dr);
            tabelOpname.Update();
            tabelOpname.Refresh();

        }
        private void tabelOpname_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Produk telah dihapus");
                tabelOpname.Rows.RemoveAt(e.RowIndex);
                productList.RemoveAt(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DariTgl.Text.Length == 0 || SampaiTgl.Text.Length == 0 || textBox1.Text.Length == 0 || productList.Count == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
                if (DariTgl.Text.Length == 0) { DariTgl.Focus(); }
                else { SampaiTgl.Focus(); }
            }
            else
            {
                string startDate = DateTime.Parse(DariTgl.Text).ToString("yyyy-MM-dd");
                string endDate = DateTime.Parse(SampaiTgl.Text).ToString("yyyy-MM-dd");
                Models.Opname opname = new Models.Opname(startDate, endDate, productList, jumlah, textBox1.Text);
                int idOpname = Database.getInstance().OpnameBaru(opname, true);
                opname.idOpname = idOpname;
                list_Opname_Stock.AddOpname(opname);
                MessageBox.Show("Data Opname Stock telah di tambahkan");
                this.Close();
            }
        }

        private void DariTgl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SampaiTgl.Focus();
            }
        }

        private void SampaiTgl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddProduk.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
