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
    public partial class View_Detail_Penjualan : Form
    {
        int rowIndex;
        Models.Transaction transaction;
        Models.Supplier supplier;
        DataSet ds;

        Penjualan penjualan;
        bool isEditing = false;

        private PrintDocument printDocument1 = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        List<Models.Product> removedProduct = new List<Models.Product>();
        List<Models.Product> addedProduct = new List<Models.Product>();
        List<string> deletedProduct = new List<string>();

        public View_Detail_Penjualan(int row, Models.Transaction transaction, Penjualan penjualan)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.rowIndex = row;
            this.penjualan = penjualan;
            this.transaction = transaction;
            InitializeComponent();
            getData();
            setViews();
        }

        private void getData()
        {
            transaction.tgl_invoice = DateTime.Parse(transaction.tgl_invoice).ToString("yyyy-MM-dd");
            supplier = Database.getInstance().GetSupplierFromId(transaction.tujuan.id);
            ds = new DataSet();
            ds.Tables.Add(new DataTable());
            ds.Tables[0].Columns.Add("ID");
            ds.Tables[0].Columns.Add("Nama Produk");
            ds.Tables[0].Columns.Add("Jumlah");
            ds.Tables[0].Columns.Add("Satuan");
            ds.Tables[0].Columns.Add("Harga");
            ds.Tables[0].Columns.Add("Diskon");
            ds.Tables[0].Columns.Add("Subtotal");

            for (int i = 0; i < transaction.produkList.Count; i++)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = transaction.produkList[i].idProduk;
                dr[1] = transaction.produkList[i].namaProduk;
                dr[2] = transaction.produkList[i].jumlah;
                dr[3] = transaction.produkList[i].jenisSatuan;
                dr[4] = transaction.produkList[i].harga;
                dr[5] = transaction.produkList[i].diskon;
                dr[6] = Convert.ToInt32(transaction.produkList[i].harga) * Convert.ToInt64(transaction.produkList[i].jumlah);
                ds.Tables[0].Rows.Add(dr);
            }

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void allowEdit(bool b)
        {
            if (b)
            {
                button1.Show();
                dateTimePicker1.Show();
                addDeleteButton();
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = false;
                dataGridView1.Columns[5].ReadOnly = false;
                dataGridView1.Columns[6].ReadOnly = true;
            }
            else
            {
                button1.Hide();
                tanggal.Text = dateTimePicker1.Text;
                dateTimePicker1.Hide();
                removeDeleteButton();
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView1.Columns[4].ReadOnly = false;
                dataGridView1.Columns[5].ReadOnly = false;
            }
        }

        public void addProduk(Models.Product product)
        {


            int found = -1;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()) == product.idProduk)
                {
                    found = i;
                    break;
                }
            }
            if (found == -1)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = product.idProduk;
                dr[1] = product.namaProduk;
                dr[2] = product.jumlah;
                dr[3] = product.jenisSatuan;
                dr[4] = product.harga;
                dr[5] = product.diskon;
                dr[6] = Convert.ToInt64(product.harga) * Convert.ToInt64(product.jumlah);
                ds.Tables[0].Rows.Add(dr);
                dataGridView1.Update();
                dataGridView1.Refresh();
                addedProduct.Add(product);
                transaction.produkList.Add(product);
            }
            else
            {
                transaction.produkList[found].jumlah += product.jumlah;
                ds.Tables[0].Rows[found][2] = transaction.produkList[found].jumlah;
            }

        }
        private void updateCalculation()
        {
            int subtotal_ = 0;
            int diskon_ = 0;
            int total_ = 0;

            for (int i = 0; i < transaction.produkList.Count; i++)
            {
                subtotal_ += (transaction.produkList[i].harga * transaction.produkList[i].jumlah);
                diskon_ += (transaction.produkList[i].diskon);

            }

            subtotal.Text = Convert.ToString(subtotal_);
            disc.Text = Convert.ToString(diskon_);
            total.Text = Convert.ToString(subtotal_ - diskon_);

        }

        private void addDeleteButton()
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "Actions";
            dataGridView1.Columns.Add(col);
        }

        private void removeDeleteButton()
        {
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
        }

        private void setViews()
        {
            button1.Hide();
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateTimePicker1.Hide();
            dateTimePicker1.Value = Convert.ToDateTime(transaction.tgl_invoice);
            namaSupplier.Text = supplier.nama;
            alamat.Text = supplier.alamat;
            telepon.Text = supplier.telepon;
            noFaktur.Text = transaction.invoice_no;
            tanggal.Text = transaction.tgl_invoice;
            updateCalculation();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateView(e.RowIndex);
        }

        private void updateView(int row)
        {
            ds.Tables[0].Rows[row][6] = Convert.ToInt64(ds.Tables[0].Rows[row][2].ToString()) * Convert.ToInt64(ds.Tables[0].Rows[row][4].ToString());
            transaction.produkList[row].harga = Convert.ToInt32(ds.Tables[0].Rows[row][4].ToString());
            transaction.produkList[row].jumlah = Convert.ToInt32(ds.Tables[0].Rows[row][2].ToString());
            transaction.produkList[row].diskon = Convert.ToInt32(ds.Tables[0].Rows[row][5].ToString());
        }

        

 

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (isEditing)
            {
                buttonEdit.Text = "EDIT";
                isEditing = false;
                transaction.tgl_invoice = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
                allowEdit(false);
                Database.getInstance().UpdatePurchase(transaction, deletedProduct, addedProduct);
                penjualan.UpdatePembelian(rowIndex, transaction);

            }
            else
            {
                buttonEdit.Text = "SAVE";
                isEditing = true;
                allowEdit(true);
            }
        }

        private void buttonAddBarang_Click_1(object sender, EventArgs e)
        {
            Retur_Pembelian retur_Pembelian = new Retur_Pembelian(transaction, "RETUR PENJUALAN");
            retur_Pembelian.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Add_Barang add_Barang = new Add_Barang(this,addedProduct,removedProduct);
            add_Barang.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 7)
            {
                if (e.RowIndex >= 0)
                {
                    removedProduct.Add(transaction.produkList[e.RowIndex]);
                    deletedProduct.Add(Convert.ToString(transaction.produkList[e.RowIndex].idProduk));
                    transaction.produkList.RemoveAt(e.RowIndex);
                    ds.Tables[0].Rows.RemoveAt(e.RowIndex);

                }
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
            string title = "FAKTUR JUAL".PadLeft(35);
            string compName = ds.Tables[0].Rows[0][1].ToString();
            string address = ds.Tables[0].Rows[0][2].ToString();

            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();

            int startX = 20;
            int startY = 20;
            int offset = 40;

            graphic.DrawString(title, new Font("Courier New", 16), new SolidBrush(Color.Black), startX, startY);
            string top = "Nama Customer".PadRight(5) + ": " + transaction.tujuan.nama + "No. Faktur".PadRight(5).PadLeft(50) + ": " + transaction.invoice_no;
            string second = "Alamat".PadRight(5) + ": " + supplier.alamat.Split('\n')[0] + "Tanggal".PadRight(5).PadLeft(50) + ": " + transaction.tgl_invoice;
            string third = "      ".PadRight(5) + "  " + supplier.alamat.Split('\n')[1];

            graphic.DrawString(compName, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString(second, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString(third, font, new SolidBrush(Color.Black), startX, startY + offset);
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

            foreach (Models.Product product in transaction.produkList)
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
                else {
                    productName = product.namaProduk;
                }

                string productListing = id.PadRight(8) + productName.PadRight(32) + jumlah.PadRight(9) + product.jenisSatuan.PadRight(6) + harga.PadLeft(10) + diskon.PadLeft(10) + subtotal.PadLeft(15);
                offset = offset + (int)fontHeight + 5;
                graphic.DrawString(productListing, f, new SolidBrush(Color.Black), startX, startY + offset);

                if (secondLine != "") {
                    lineNum += 1;
                    offset = offset + (int)fontHeight;
                    graphic.DrawString(secondLine.PadLeft(10), f, new SolidBrush(Color.Black), startX, startY + offset);
                }

            
            }
            if (lineNum < 7)
            {
                for (int i = 0; i < (7 - transaction.produkList.Count); i++)
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

            string bottom = "Description : ".PadRight(20)+"Subtotal".PadLeft(50) +":" + (" Rp." + subtotal.Text).PadLeft(18);
            string bottom2 = "Diskon".PadLeft(70) + ":" + (" Rp." + disc.Text).PadLeft(18);
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

        private void print_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            for (int i = 0; i < removedProduct.Count; i++)
            {
                transaction.produkList.Add(removedProduct[i]);
            }
            Console.WriteLine("Fuck");
        }
    }
}
