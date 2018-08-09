using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{


    public class Transaction : BasicServerModel
    {
        public string invoice_no;
        public Supplier tujuan;
        public string tgl_invoice;
        public string deskripsi;
        public int biaya_kirim;
        public List<Product> produkList;


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
