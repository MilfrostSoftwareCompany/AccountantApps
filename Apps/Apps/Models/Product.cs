using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{
    public class Product : BasicServerModel
    {
        public int idProduk;
        public string namaProduk;
        public int jumlah;
        public string jenisSatuan;
        public int harga;
        public int diskon;

        public Product(int idProduk,string namaProduk, int jumlah, string jenisSatuan, int harga)
        {

            this.idProduk = idProduk;
            this.namaProduk = namaProduk;
            this.jumlah = jumlah;
            this.jenisSatuan = jenisSatuan;
            this.harga = harga;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");

        }

        public Product(string namaProduk, int jumlah, string jenisSatuan, int harga) {
            this.namaProduk = namaProduk;
            this.jumlah = jumlah;
            this.jenisSatuan = jenisSatuan;
            this.harga = harga;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");

        }

        public void setDiskon(int d) {
            diskon = d;
        }

        public int getTotal()
        {
            return (harga * jumlah) - diskon;
        }
    }
}
