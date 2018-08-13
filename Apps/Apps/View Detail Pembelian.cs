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
    public partial class View_Detail_Pembelian : Form
    {
        int rowIndex;
        Models.Transaction transaction;
        Models.Supplier supplier;
        DataSet ds;

        private PrintDocument printDocument1 = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();


        Pembelian pembelian;
        bool isEditing = false;

        List<Models.Product> addedProduct = new List<Models.Product>();
        List<string> deletedProduct = new List<string>();

        public View_Detail_Pembelian(int row,Models.Transaction transaction,Pembelian pembelian)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            
            this.rowIndex = row;
            this.pembelian = pembelian;
            this.transaction = transaction;
            InitializeComponent();
            getData();
            setViews();
        }

        private void getData()
        {
            if (Login.permissionlvl != 1) {
                buttonEdit.Hide();
            }

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
        
            for (int i = 0; i < transaction.produkList.Count; i++) {
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

        private void allowEdit(bool b) {
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
            else {
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

        public void addProduk(Models.Product product) {
            

            int found = -1;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                if (Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()) == product.idProduk) {
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
            else {
                transaction.produkList[found].jumlah += product.jumlah;
                ds.Tables[0].Rows[found][2] = transaction.produkList[found].jumlah;
            }
            
        }
        private void updateCalculation()
        {
            int subtotal_ = 0;
            int diskon_ = 0;
            int total_ = 0;

            for (int i = 0; i < transaction.produkList.Count; i++) {
                subtotal_ += (transaction.produkList[i].harga * transaction.produkList[i].jumlah);
                diskon_ += (transaction.produkList[i].diskon);
                
            }

            subtotal.Text = Convert.ToString(subtotal_);
            disc.Text = Convert.ToString(diskon_);
            total.Text = Convert.ToString(subtotal_-diskon_);
            
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

        private void updateView(int row) {
            ds.Tables[0].Rows[row][6] = Convert.ToInt64(ds.Tables[0].Rows[row][2].ToString()) * Convert.ToInt64(ds.Tables[0].Rows[row][4].ToString());
            transaction.produkList[row].harga = Convert.ToInt32(ds.Tables[0].Rows[row][4].ToString());
            transaction.produkList[row].jumlah = Convert.ToInt32(ds.Tables[0].Rows[row][2].ToString());
            transaction.produkList[row].diskon = Convert.ToInt32(ds.Tables[0].Rows[row][5].ToString());
        }

        private void buttonAddBarang_Click(object sender, EventArgs e)
        {
            Retur_Pembelian retur_Pembelian = new Retur_Pembelian(transaction,"RETUR PEMBELIAN");
            retur_Pembelian.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 7) {
                if (e.RowIndex >= 0) {

                    deletedProduct.Add(Convert.ToString(transaction.produkList[e.RowIndex].idProduk));
                    transaction.produkList.RemoveAt(e.RowIndex);
                    ds.Tables[0].Rows.RemoveAt(e.RowIndex);
                    
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                buttonEdit.Text = "EDIT";
                isEditing = false;
                transaction.tgl_invoice = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
                allowEdit(false);
                Database.getInstance().UpdatePurchase(transaction,deletedProduct,addedProduct);
                pembelian.UpdatePembelian(rowIndex,transaction);

            }
            else {
                buttonEdit.Text = "SAVE";
                isEditing = true;
                allowEdit(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Barang add_Barang = new Add_Barang(this);
            add_Barang.ShowDialog();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            Database.getInstance().DeletePurchase(transaction.invoice_no);
            pembelian.deleteData(rowIndex);
            this.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            
            CaptureScreen();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
        }


        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

    }
}
