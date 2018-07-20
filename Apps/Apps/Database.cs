using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Reflection;
using System.Data;
using System.Windows.Forms;
using Apps.Classes;

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
            Console.WriteLine("Select id_supplier as ID, nama as Nama, alamat as Alamat, telepon as Telepon From suppliers WHERE ID = '" + query + "' OR Nama LIKE '%" + query + "%'");
            string queryString = "Select id_supplier as ID, nama as Nama, alamat as Alamat, telepon as Telepon From suppliers WHERE ID = '" + query + "' OR Nama LIKE '%" + query+"%'";
            


            SQLiteDataAdapter adapter = new SQLiteDataAdapter(queryString, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            return ds;

        }

        public void CreateNewSupplier(Apps.Models.Supplier supplier)
        {
            sqlConnection.Open();   
                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Supplier (nama, alamat, telepon, created_by, creation_time) VALUES (?,?,?,?)", sqlConnection);
                insertSQL.Parameters.Add(supplier.nama);
                insertSQL.Parameters.Add(supplier.alamat);
                insertSQL.Parameters.Add(supplier.telepon);
                insertSQL.Parameters.Add(supplier.createdBy);
                insertSQL.Parameters.Add(supplier.creationTime);
                try
                {
                    insertSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }


        public DataSet getAllCustomerData()
        {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select id_customer as ID, nama as Nama, alamat as Alamat, telepon as Telepon From customers", sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            return ds;

        }

        public bool login(string username,string password)
        {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select password FROM users WHERE username = '"+username.ToLower()+"'", sqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                String pwd = ds.Tables[0].Rows[0][0].ToString();
                return PasswordHasher.Verify(password, pwd);
            }
        }
    }
}
