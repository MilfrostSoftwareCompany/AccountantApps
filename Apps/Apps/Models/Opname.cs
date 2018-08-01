using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Models
{
    public class Opname:BasicServerModel
    {
        public List<Models.Product> product;
        public string startDate;
        public string endDate;
        public string doneBy;
        public List<int> jumlah;
        public int idOpname;

        public Opname(int idOpname,string startDate, string endDate, List<Models.Product> product, List<int> jumlah,string doneBy) {
            this.idOpname = idOpname;
            this.startDate = startDate;
            this.endDate = endDate;
            this.product = product;
            this.jumlah = jumlah;
            this.doneBy = doneBy;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public Opname( string startDate, string endDate, List<Models.Product> product, List<int> jumlah,string doneBy)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.product = product;
            this.jumlah = jumlah;
            this.doneBy = doneBy;
            this.createdBy = Login.loggedUser;
            this.creationTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }
    }
}
