using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{
    public class ReturTransaksi : BasicServerModel
    {
        public int type;

        public List<Product> productList;
        public string idTransaksi;
        public Transaction transaction;
        public string idRetur;
        public string tglRetur;
        public string deskripsi;
        public int idSupplier;
        public Supplier supplier;

        public ReturTransaksi(string idRetur, string idTransaksi, string tglRetur, string deskripsi)
        {
            this.productList = new List<Product>();
            this.idRetur = idRetur;
            this.idTransaksi = idTransaksi;
            this.tglRetur = tglRetur;
            this.deskripsi = deskripsi;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public ReturTransaksi(string idRetur, string idTransaksi, string tglRetur, List<Product> productList, string deskripsi)
        {
            this.productList = new List<Product>();
            this.idRetur = idRetur;
            this.idTransaksi = idTransaksi;
            this.tglRetur = tglRetur;
            this.productList = productList;
            this.deskripsi = deskripsi;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public Transaction GetTransaction()
        {
            Transaction transaction;
            if (type == 0)
            {
                transaction = new Transaction(Database.getInstance().GetPurchase(idTransaksi).Tables[0]);
                transaction.type = type;
            }
            else {
                transaction = new Transaction(Database.getInstance().GetSell(idTransaksi).Tables[0]);
                transaction.type = type;
            }
            return transaction;
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;
            for (int i = 0; i < productList.Count; i++) {
                totalPrice += ((productList[i].harga * productList[i].jumlah) - productList[i].diskon);
            }
            return totalPrice;
        }

        public void setProdukList(DataTable data) {
            for (int i = 0; i < data.Rows.Count; i++) {
                Console.WriteLine(i);
                Product product = new Product(Convert.ToInt32(data.Rows[i][0].ToString()),data.Rows[i][1].ToString(),Convert.ToInt32(data.Rows[i][2].ToString()), data.Rows[i][3].ToString(), Convert.ToInt32(data.Rows[i][4].ToString()));
                productList.Add(product);
            }
        }
    }
}
