using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{
    public class ReturTransaksi : BasicServerModel
    {
        public List<Product> productList;
        public string idTransaksi;
        public Transaction transaction;
        public string idRetur;
        public string tglRetur;
        public string deskripsi;
        public int idSupplier;
        public Supplier supplier;
       
        public ReturTransaksi(string idRetur, string idTransaksi, List<Product> productList, string deskripsi)
        {
            this.idRetur = idRetur;
            this.idTransaksi = idTransaksi;
            this.productList = productList;
            this.deskripsi = deskripsi;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;
            for (int i = 0; i < productList.Count; i++) {
                totalPrice += ((productList[i].harga * productList[i].jumlah) - productList[i].diskon);
            }
            return totalPrice;
        }
    }
}
