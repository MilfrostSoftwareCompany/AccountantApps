using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Retur_Pembelian : Form
    {
        Models.Transaction transaction;
        DataSet ds;

        List<Models.Product> addedProduct = new List<Models.Product>();
        List<Models.Product> removedProduct = new List<Models.Product>();

        private PrintDocument printDocument1 = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        Models.ReturTransaksi returTransaksi;
        bool isEdit = false;
        bool isEditing = false;

        bool isPembelian = false;

        public Retur_Pembelian(Models.ReturTransaksi transaksi, string title) {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            isEdit = true;
            this.returTransaksi = transaksi;
            InitializeComponent();
            label3.Text = title;
            textBox1.Text = transaksi.idRetur;
            textBox1.ReadOnly = true;
            lblTgl.Text = transaksi.tglRetur;
            tanggal.Text = transaksi.tglRetur;
            tanggal.Hide();
            tambahProdukBtn.Hide();
            if (title == "RETUR PEMBELIAN")
            {
                isPembelian = true;
                returTransaksi.type = 0;
                transaction = returTransaksi.GetTransaction();
                returTransaksi.setProdukList(Database.getInstance().GetTotalRelatedPurchaseReturnProduct(returTransaksi.idRetur).Tables[0]);
            }
            else {
                returTransaksi.type = 1;
                transaction = returTransaksi.GetTransaction();
                returTransaksi.setProdukList(Database.getInstance().GetTotalRelatedSellReturnProduct(returTransaksi.idRetur).Tables[0]);
            }
            SetTransData();

            textBox1.Focus();

            if (Login.permissionlvl != 1) {
                edit_btn.Hide();
            }
        }
        
        private void SetTransData() {

            ds = new DataSet();
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("ID");
            ds.Tables[0].Columns.Add("Nama Produk");
            ds.Tables[0].Columns.Add("Jumlah");
            ds.Tables[0].Columns.Add("Satuan");
            ds.Tables[0].Columns.Add("Harga");
            ds.Tables[0].Columns.Add("Diskon");
            ds.Tables[0].Columns.Add("Subtotal");

            for (int i = 0; i < returTransaksi.productList.Count; i++)
            {
                addedProduct.Add(returTransaksi.productList[i]);
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = returTransaksi.productList[i].idProduk;
                dr[1] = returTransaksi.productList[i].namaProduk;
                dr[2] = returTransaksi.productList[i].jumlah;
                dr[3] = returTransaksi.productList[i].jenisSatuan;
                dr[4] = returTransaksi.productList[i].harga;
                dr[5] = returTransaksi.productList[i].diskon;
                dr[6] = Convert.ToInt64(returTransaksi.productList[i].harga) * Convert.ToInt64(returTransaksi.productList[i].jumlah);
                ds.Tables[0].Rows.Add(dr);

            }
            dataGridView1.DataSource = ds.Tables[0];
            //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            //col.UseColumnTextForButtonValue = true;
            //col.Text = "Delete";
            //col.Name = "Actions";
            //dataGridView1.Columns.Add(col);

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            namasupplier.Text = transaction.tujuan.nama;
            alamat.Text = transaction.tujuan.alamat;
            noFaktur.Text = transaction.invoice_no;

            UpdateCalculation();

        }

        public Retur_Pembelian(Models.Transaction transaction,string title)
        {
            this.transaction = transaction;
            InitializeComponent();
            label3.Text = title;
            GetData();
            SetViews();
            
        }

        private void GetData()
        {
            transaction.tujuan = Database.getInstance().GetSupplierFromId(transaction.tujuan.id);
            ds = new DataSet();
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("ID");
            ds.Tables[0].Columns.Add("Nama Produk");
            ds.Tables[0].Columns.Add("Jumlah");
            ds.Tables[0].Columns.Add("Satuan");
            ds.Tables[0].Columns.Add("Harga");
            ds.Tables[0].Columns.Add("Diskon");
            ds.Tables[0].Columns.Add("Subtotal");

            for(int i = 0; i < transaction.produkList.Count; i++)
            {
                addedProduct.Add(transaction.produkList[i]);
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = transaction.produkList[i].idProduk;
                dr[1] = transaction.produkList[i].namaProduk;
                dr[2] = transaction.produkList[i].jumlah;
                dr[3] = transaction.produkList[i].jenisSatuan;
                dr[4] = transaction.produkList[i].harga;
                dr[5] = transaction.produkList[i].diskon;
                dr[6] = Convert.ToInt64(transaction.produkList[i].harga)*Convert.ToInt64(transaction.produkList[i].jumlah);
                ds.Tables[0].Rows.Add(dr);
                
            }
            dataGridView1.DataSource = ds.Tables[0];
            if (isEdit)
            {
                edit_btn.Show();
            }
            else
            {
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Delete";
                col.Name = "Actions";
                dataGridView1.Columns.Add(col);
                edit_btn.Hide();
            }

        }

        private void AllowEdit(bool b)
        {
            if (b)
            {
                tambahProdukBtn.Show();
                tanggal.Show();
                lblTgl.Hide();
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = false;
                dataGridView1.Columns[5].ReadOnly = false;
                dataGridView1.Columns[6].ReadOnly = true;
                AddDeleteBtn();
            }
            else {
                tambahProdukBtn.Hide();
                tanggal.Hide();
                lblTgl.Text = tanggal.Text;
                lblTgl.Show();
                RemoveDeleteBtn();
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView1.Columns[4].ReadOnly = false;
                dataGridView1.Columns[5].ReadOnly = false;
            }
        }

        private void AddDeleteBtn()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Actions";
            dataGridView1.Columns.Add(col);
        }

        private void RemoveDeleteBtn()
        {
            dataGridView1.Columns.RemoveAt(7);
        }

        public void SetViews()
        {
            if (isEdit) {

            }

            if (label3.Text == "RETUR PEMBELIAN")
            {
                label4.Text = "Nama Supplier";
            }
            else if (label3.Text == "RETUR PENJUALAN") {
                label4.Text = "Nama Customer";
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            namasupplier.Text = transaction.tujuan.nama;
            alamat.Text = transaction.tujuan.alamat;
            noFaktur.Text = transaction.invoice_no;

            UpdateCalculation();

        }

        private void UpdateCalculation() {
            int subtotal_ = 0;
            int diskon_ = 0;
            int total_ = 0;

            if (isEdit)
            {
                for (int i = 0; i < returTransaksi.productList.Count; i++)
                {
                    subtotal_ += (returTransaksi.productList[i].harga * returTransaksi.productList[i].jumlah);
                    diskon_ += (returTransaksi.productList[i].diskon);

                }
            }
            else {
                for (int i = 0; i < transaction.produkList.Count; i++)
                {
                    subtotal_ += (transaction.produkList[i].harga * transaction.produkList[i].jumlah);
                    diskon_ += (transaction.produkList[i].diskon);

                }

            }

            

            subtotal.Text = Convert.ToString(subtotal_);
            disc.Text = Convert.ToString(diskon_);
            total.Text = Convert.ToString(subtotal_ - diskon_);
        }

        public void AddProduct(Models.Product product) {
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = product.idProduk;
            dr[1] = product.namaProduk;
            dr[2] = product.jumlah;
            dr[3] = product.jenisSatuan;
            dr[4] = product.harga;
            dr[5] = product.diskon;
            dr[6] = Convert.ToInt64(product.harga) * Convert.ToInt64(product.jumlah);
            ds.Tables[0].Rows.Add(dr);
            addedProduct.Add(product);
            removeFromRemovedList(product.idProduk);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void removeFromRemovedList(int id) {
            for (int i = 0; i < removedProduct.Count; i++) {
                if (removedProduct[i].idProduk == id) {
                    removedProduct.RemoveAt(i);
                    break;
                }
            }
        }

        int countItem = 0;
        private void tambahProdukBtn_Click(object sender, EventArgs e)
        {
            if (countItem < 7)
            {
                if (countItem == 6)
                {
                    tambahProdukBtn.Visible = false;
                }
                if (removedProduct.Count == 0)
                {
                    MessageBox.Show("Tidak ada barang yang bisa ditambahkan.");
                }
                else
                {
                    Add_Barang add_Barang = new Add_Barang(this, removedProduct);
                    add_Barang.ShowDialog();
                    countItem++;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Anda yakin ?", "DELETE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                if (e.ColumnIndex == 0)
                {
                    removedProduct.Add(addedProduct[e.RowIndex]);
                    addedProduct.RemoveAt(e.RowIndex);
                    ds.Tables[0].Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void buttonRetur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Silahkan isi ID Retur");
            }
            else
            {
                Models.ReturTransaksi retur = new Models.ReturTransaksi(textBox1.Text, transaction.invoice_no, DateTime.Parse(tanggal.Text).ToString("yyyy-MM-dd"), addedProduct, deskripsi.Text);

                if (label3.Text == "RETUR PEMBELIAN")
                {
                    if (Database.getInstance().IsPurchaseReturnExist(retur.idRetur) == 0)
                    {
                        Database.getInstance().CreateNewPurchaseReturn(retur);
                    }
                    else {
                        MessageBox.Show("Gunakan Id retur yang baru");
                    }
                }
                else if(label3.Text == "RETUR PENJUALAN")
                {
                    if (Database.getInstance().IsSellReturnExist(retur.idRetur) == 0)
                    {
                        Database.getInstance().CreateNewSellReturn(retur);
                    }
                    else {
                        MessageBox.Show("Gunakan Id retur yang baru");
                    }
                }
                this.Close();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                AllowEdit(false);
                isEditing = false;
                tambahProdukBtn.Hide();
                edit_btn.Text = "EDIT";
                returTransaksi.tglRetur = DateTime.Parse(tanggal.Text).ToString("yyyy-MM-dd");
                //code update to database
                if (isPembelian)
                {
                    Database.getInstance().UpdatePurchaseReturn(returTransaksi,removedProduct,addedProduct);
                }
                else {
                    Database.getInstance().UpdateSellReturn(returTransaksi,removedProduct,addedProduct);
                }
                this.Close();
            }
            else {
                AllowEdit(true);
                isEditing = true;
                edit_btn.Text = "SAVE";
                tambahProdukBtn.Show();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tanggal.Focus();
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataSet ds = Database.getInstance().GetCompanyDetails();
            string title = "";
            if (isPembelian)
                title = "RETUR BELI".PadLeft(35);
            else
                title = "RETUR JUAL".PadLeft(35);
            string compName = ds.Tables[0].Rows[0][1].ToString();
            string address = ds.Tables[0].Rows[0][2].ToString();

            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();

            int startX = 20;
            int startY = 20;
            int offset = 40;



            graphic.DrawString(title, new Font("Courier New", 16), new SolidBrush(Color.Black), startX, startY);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString(compName, font, new SolidBrush(Color.Black), startX, startY + offset);
            string top = "Nama Customer".PadRight(15) + ": " + transaction.tujuan.nama.PadRight(40) + "No. Faktur".PadRight(10) + ": " + returTransaksi.idRetur;
            if (transaction.tujuan.alamat.Contains("\n"))
            {
                string second = "Alamat".PadRight(15) + ": " + transaction.tujuan.alamat.Split('\n')[0].PadRight(40) + "Tanggal".PadRight(10) + ": " + returTransaksi.tglRetur;
                string third = "      ".PadRight(15) + "  " + transaction.tujuan.alamat.Split('\n')[1];
                offset = offset + (int)fontHeight + 5; //make the spacing consistent
                graphic.DrawString(second, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight; //make the spacing consistent
                graphic.DrawString(third, font, new SolidBrush(Color.Black), startX, startY + offset);
            }

            else {
                string second = "Alamat".PadRight(15) + ": " + transaction.tujuan.alamat.PadRight(35) + "Tanggal".PadRight(5).PadLeft(15) + ": " + returTransaksi.tglRetur;
                
                offset = offset + (int)fontHeight + 5; //make the spacing consistent
                graphic.DrawString(second, font, new SolidBrush(Color.Black), startX, startY + offset);
            }

            
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString("-------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            string fourth = "No".PadRight(8) + "Nama Produk".PadRight(32) + "Jumlah".PadRight(9) + "Satuan".PadRight(6) + "Harga".PadLeft(10) + "Diskon".PadLeft(10) + "Subtotal".PadLeft(15);
            graphic.DrawString(fourth, font, new SolidBrush(Color.Black), startX, startY + offset);
            float totalprice = 0.00f;



            Font f = new Font("Courier New", 10);
            offset = offset + (int)fontHeight + 10; //make the spacing consistent
            graphic.DrawString("-------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            int lineNum = 0;

            foreach (Models.Product product in returTransaksi.productList)
            {
                lineNum += 1;
                string id = product.idProduk.ToString();
                string jumlah = product.jumlah.ToString();
                string harga = product.harga.ToString();
                string diskon = product.diskon.ToString();
                string subtotal = product.getTotal().ToString();
                string productName = "";
                string secondLine = "";
                if (product.namaProduk.Length > 30)
                {
                    productName = product.namaProduk.Substring(0, 30);
                    secondLine = product.namaProduk.Substring(30, product.namaProduk.Length - 30);
                }
                else
                {
                    productName = product.namaProduk;
                }

                string productListing = id.PadRight(8) + productName.PadRight(32) + jumlah.PadRight(9) + product.jenisSatuan.PadRight(6) + harga.PadLeft(10) + diskon.PadLeft(10) + subtotal.PadLeft(15);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString(productListing, f, new SolidBrush(Color.Black), startX, startY + offset);

                if (secondLine != "")
                {
                    lineNum += 1;
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(secondLine.PadLeft(10), f, new SolidBrush(Color.Black), startX, startY + offset);
                }


            }
            if (lineNum < 7)
            {
                for (int i = 0; i < (7 - returTransaksi.productList.Count); i++)
                {
                    offset = offset + (int)fontHeight + 5;
                }
            }
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("-------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            Pen blackPen = new Pen(Color.Black, 1);
            Rectangle rect = new Rectangle(20, 380, 450, 40);
            graphic.DrawRectangle(blackPen, rect);

            string bottom = "Description : ".PadRight(20) + "Subtotal".PadLeft(50) + ":" + (" Rp." + subtotal.Text).PadLeft(18);
            string bottom2 = returTransaksi.deskripsi.PadRight(40) + "Diskon".PadLeft(30) + ":" + (" Rp." + disc.Text).PadLeft(18);
            string bottom3 = "Total".PadLeft(70) + ":" + (" Rp." + total.Text).PadLeft(18);

            graphic.DrawString(bottom, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString(bottom2, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString(bottom3, font, new SolidBrush(Color.Black), startX, startY + offset);

            string bottom5 = "Hormat Kami".PadLeft(15) + "Diterima Oleh".PadLeft(35) + "Diketahui Oleh".PadLeft(35);
            string bottom6 = "(         )".PadLeft(15) + "(           )".PadLeft(35) + "(            )".PadLeft(35);
            offset = offset + (int)fontHeight + 15;
            graphic.DrawString(bottom5, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString(bottom6, font, new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
}
