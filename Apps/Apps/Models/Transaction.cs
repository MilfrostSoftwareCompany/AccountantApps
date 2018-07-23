using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{

    


    class Transaction : BasicServerModel
    {
        public string invoice_no;
        public string tujuan;
        public string tgl_invoice;
        public string deskripsi;
        public int biaya_kirim;
        public List<Product> produkList;


        public Transaction(string tujuan, string tgl_invoice, string deskripsi, int biaya_kirim,List<Product> produkList)
        {
            this.tujuan = tujuan;
            this.tgl_invoice = tgl_invoice;
            this.deskripsi = deskripsi;
            this.biaya_kirim = biaya_kirim;
            this.produkList = produkList;
        }

        public Transaction(string invoice_no, string tujuan, string tgl_invoice, string deskripsi, int biaya_kirim, List<Product> produkList) {
            this.invoice_no = invoice_no;
            this.tujuan = tujuan;
            this.tgl_invoice = tgl_invoice;
            this.deskripsi = deskripsi;
            this.biaya_kirim = biaya_kirim;
            this.produkList = produkList;
        }
    }
}
