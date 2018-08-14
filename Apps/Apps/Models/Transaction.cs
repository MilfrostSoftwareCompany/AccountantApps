using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{


    public class Transaction : BasicServerModel
    {
        public int type;
        public string invoice_no;
        public Supplier tujuan;
        public string tgl_invoice;
        public string deskripsi;
        public int biaya_kirim;
        public List<Product> produkList;


        public Transaction(DataTable dataTable) {
            this.invoice_no = dataTable.Rows[0][0].ToString();
            if (type == 0)
            {
                this.tujuan = new Models.Supplier(Database.getInstance().getSupplierQuery(dataTable.Rows[0][3].ToString()).Tables[0].Rows[0]);
            }
            else {
                this.tujuan = new Models.Supplier(Database.getInstance().getQueryCustomer(dataTable.Rows[0][3].ToString()).Tables[0].Rows[0]);
            }

            this.tgl_invoice = dataTable.Rows[0][2].ToString();
        }

        public Transaction(Supplier tujuan, string tgl_invoice,List<Product> produkList)
        {
            this.tujuan = tujuan;
            this.tgl_invoice = tgl_invoice;
            this.produkList = produkList;
            this.biaya_kirim = 0;
            this.deskripsi = "";
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public Transaction(string invoice_no, Supplier tujuan, string tgl_invoice, List<Product> produkList) {
            this.invoice_no = invoice_no;
            this.tujuan = tujuan;
            this.tgl_invoice = tgl_invoice;
            this.produkList = produkList;
            this.biaya_kirim = 0;
            this.deskripsi = "";
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }
    }
}
