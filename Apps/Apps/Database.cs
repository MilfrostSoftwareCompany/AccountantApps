using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Reflection;
using System.Data;

namespace Apps
{
    class Database
    {
        static Database database;
        SQLiteConnection sqlConnection;

        public Database()
        {
            sqlConnection = new SQLiteConnection("Data Source = "+Environment.CurrentDirectory + "\\Database\\acc_app.sqlite");
        }

        public static Database getInstance() {
            if (database == null)
            {
                database = new Database();
            }
            return database;
        }


        //methods related to suppliers
        public DataSet getAllSupplierData()
        {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select id_supplier as ID, nama as Nama, alamat as Alamat, telepon as Telepon From suppliers", sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            return ds;
            
        }

        public DataSet getSupplierQuery(string query) {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select id_supplier as ID, nama as Nama, alamat as Alamat, telepon as Telepon From suppliers WHERE ID CONTAINS "+query+" OR Nama CONTAINS "+query, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            return ds;

        }

        public DataSet getAllCustomerData()
        {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select id_customer as ID, nama as Nama, alamat as Alamat, telepon as Telepon From customers", sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            return ds;

        }
    }
}
