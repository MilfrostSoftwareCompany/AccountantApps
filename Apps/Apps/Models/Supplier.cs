using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{
    public class Supplier : BasicServerModel
    {
        public string nama;
        public string alamat;
        public string telepon;
        public string id;
        public Supplier(string id,string nama, string alamat, string telepon)
        {
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.telepon = telepon;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public Supplier(string nama, string alamat, string telepon) {
            this.nama = nama;
            this.alamat = alamat;
            this.telepon = telepon;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }
    }
}
