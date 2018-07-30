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
            sqlConnection = new SQLiteConnection("Data Source = " + Environment.CurrentDirectory + "\\Database\\acc_app.sqlite");
            sqlConnection.Open();
            CreateTableIfNotExist();
            sqlConnection.Close();
        }

        public static Database getInstance()
        {
            if (database == null)
            {
                database = new Database();
            }
            return database;
        }

        private void CreateActivityTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'activity'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "activity")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'activity' ('id' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 'created_by' TEXT, 'creation_time' DATETIME DEFAULT CURRENT_TIMESTAMP, 'activity_type' TEXT, 'activity_id' TEXT)";
                command.ExecuteNonQuery();
            }
        }

        private void CreateCustomerTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'customers'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "customers")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'customers' ('id_customer' INTEGER PRIMARY KEY  NOT NULL  DEFAULT (null) ,'nama' TEXT,'alamat' TEXT,'telepon' TEXT,'creation_date' TEXT,'created_by' TEXT)";
                command.ExecuteNonQuery();
            }
        }

        private void CreateDetailOpnameTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'detail_opname'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "detail_opname")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'detail_opname' ('id_detail' INTEGER PRIMARY KEY  NOT NULL  UNIQUE , 'id_produk' INTEGER, 'id_opname' INTEGER, 'jumlah' INTEGER)";
                command.ExecuteNonQuery();
            }
        }
        private void CreateDetailPembelianTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'detail_pembelian'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "detail_pembelian")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'detail_pembelian' ('id_detail' INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE , 'invoice_no' TEXT, 'id_produk' INTEGER, 'harga_produk' INTEGER, 'kuantitas' INTEGER DEFAULT 1, 'diskon' FLOAT DEFAULT 0)";
                command.ExecuteNonQuery();
            }
        }
        private void CreateDetailPenjualan()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'detail_penjualan'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "detail_penjualan")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'detail_penjualan' ('id_detail' INTEGER PRIMARY KEY  NOT NULL  UNIQUE , 'invoice_no' TEXT, 'id_produk' INTEGER, 'harga_produk' INTEGER, 'kuantitas' INTEGER, 'diskon' FLOAT)";
                command.ExecuteNonQuery();
            }
        }

        private void CreateOpnameStockTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'opname_stock'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "opname_stock")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'opname_stock' ('id_opname' INTEGER PRIMARY KEY  NOT NULL  UNIQUE , 'done_by' TEXT, 'created_by' TEXT, 'dari' DATETIME, 'hingga' DATETIME, 'creation_time' DATETIME DEFAULT CURRENT_TIMESTAMP)";
                command.ExecuteNonQuery();
            }
        }

        private void CreatePembelianTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'pembelian'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "pembelian")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'pembelian' ('invoice_no' TEXT PRIMARY KEY  NOT NULL  DEFAULT (null) ,'tujuan' INTEGER,'tgl_invoice' DATETIME DEFAULT (CURRENT_DATE) ,'deskripsi' TEXT,'biaya_kirim' INTEGER DEFAULT (0) , 'created_by' TEXT, 'creation_time' DATETIME)";
                command.ExecuteNonQuery();
            }
        }

        private void CreatePenjualanTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'penjualan'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "penjualan")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'penjualan' ('invoice_no' TEXT PRIMARY KEY  NOT NULL  UNIQUE , 'supplier' TEXT, 'tgl_invoice' DATETIME, 'deskripsi' TEXT, 'biaya_kirim' INTEGER, 'created_by' TEXT, 'creation_time' DATETIME)";
                command.ExecuteNonQuery();
            }
        }

        private void CreateProdukTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'produk'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "produk")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'produk' ('id_produk' INTEGER PRIMARY KEY  NOT NULL  DEFAULT (null) ,'nama_produk' TEXT,'jumlah' NUMERIC DEFAULT (0) ,'jenis_barang' TEXT,'harga' FLOAT,'created_by' TEXT,'creation_date' TEXT,'jenis_satuan' TEXT)";
                command.ExecuteNonQuery();
            }
        }
        private void CreateSupplierTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'suppliers'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "suppliers")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'suppliers' ('id_supplier' INTEGER PRIMARY KEY  NOT NULL  DEFAULT (null) ,'nama' TEXT,'alamat' TEXT,'telepon' TEXT,'creation_date' TEXT,'created_by' TEXT)";
                command.ExecuteNonQuery();
            }
        }



        private void CreateUsersTable()
        {
            SQLiteCommand command = sqlConnection.CreateCommand();
            command.CommandText = "Select name FROM sqlite_master WHERE name = 'users'";
            var acti = command.ExecuteScalar();
            if (acti != null && acti.ToString() == "users")
            {
                return;
            }
            else
            {
                command.CommandText = "CREATE TABLE 'users' ('username' TEXT PRIMARY KEY  NOT NULL  UNIQUE , 'password' TEXT, 'permission_lvl' INTEGER)";
                command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO users (username, password,permission_lvl) VALUES ('admin01', '$MYHASH$V1$10000$H3j+M3V7uXuqaiPU78tNZFNWDpqD6byI7ArZY0ZuyaMGkmqm','1')";
                command.ExecuteNonQuery();
            }
        }

        public void CreateTableIfNotExist() {
            CreateUsersTable();
            CreateActivityTable();
            CreateCustomerTable();
            CreateDetailOpnameTable();
            CreatePembelianTable();
            CreatePenjualanTable();
            CreateProdukTable();
            CreateSupplierTable();
            CreateUsersTable();


            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'customers'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'detail_opname'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'detail_pembelian'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'detail_penjualan'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'opname_stock'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'pembelian'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'penjualan'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'produk'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'suppliers'";
            //command.CommandText = "Select name FROM sqlite_master WHERE name = 'users'";
        }


        //methods related to suppliers
        public DataSet getAllSupplierData()
        {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select id_supplier as ID, nama as Nama, alamat as Alamat, telepon as Telepon From suppliers", sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            return ds;

        }

        public DataSet getSupplierQuery(string query)
        {

            sqlConnection.Open();
            Console.WriteLine("Select id_supplier as ID, nama as Nama, alamat as Alamat, telepon as Telepon From suppliers WHERE ID = '" + query + "' OR Nama LIKE '%" + query + "%'");
            string queryString = "Select id_supplier as ID, nama as Nama, alamat as Alamat, telepon as Telepon From suppliers WHERE ID = '" + query + "' OR Nama LIKE '%" + query + "%'";



            SQLiteDataAdapter adapter = new SQLiteDataAdapter(queryString, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            return ds;

        }

        public int CreateNewSupplier(Apps.Models.Supplier supplier)
        {
            int res;
            sqlConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO suppliers (nama, alamat, telepon, created_by, creation_date) VALUES (@nama,@alamat,@telepon,@created_by,@creation_date)", sqlConnection);
            insertSQL.CommandType = CommandType.Text;
            insertSQL.Parameters.AddWithValue("@nama", supplier.nama);
            insertSQL.Parameters.AddWithValue("@alamat", supplier.alamat);
            insertSQL.Parameters.AddWithValue("@telepon", supplier.telepon);
            insertSQL.Parameters.AddWithValue("@created_by", supplier.createdBy);
            insertSQL.Parameters.AddWithValue("@creation_date", supplier.creationTime);

            try
            {
                res = insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            sqlConnection.Close();
            return res;
        }

        //Customer Related Functions

        public DataSet getAllCustomerData()
        {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select id_customer as ID, nama as Nama, alamat as Alamat, telepon as Telepon From customers", sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            return ds;

        }

        public int CreateNewCustomer(Apps.Models.Customer customer)
        {
            int res;
            sqlConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO customers (nama, alamat, telepon, created_by, creation_date) VALUES (@nama,@alamat,@telepon,@created_by,@creation_date)", sqlConnection);
            insertSQL.CommandType = CommandType.Text;
            insertSQL.Parameters.AddWithValue("@nama", customer.nama);
            insertSQL.Parameters.AddWithValue("@alamat", customer.alamat);
            insertSQL.Parameters.AddWithValue("@telepon", customer.telepon);
            insertSQL.Parameters.AddWithValue("@created_by", customer.createdBy);
            insertSQL.Parameters.AddWithValue("@creation_date", customer.creationTime);

            try
            {
                res = insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            sqlConnection.Close();
            return res;
        }

        public DataSet getQueryCustomer(string query)
        {

            sqlConnection.Open();
            Console.WriteLine("Select id_customer as ID, nama as Nama, alamat as Alamat, telepon as Telepon From customers WHERE ID = '" + query + "' OR Nama LIKE '%" + query + "%'");
            string queryString = "Select id_customer as ID, nama as Nama, alamat as Alamat, telepon as Telepon From customers WHERE ID = '" + query + "' OR Nama LIKE '%" + query + "%'";



            SQLiteDataAdapter adapter = new SQLiteDataAdapter(queryString, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            return ds;

        }

        //Product related functions
        public DataSet GetAllProducts()
        {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select id_produk as ID, nama_produk as [Nama Produk], jumlah as Stock, jenis_satuan as Satuan, harga as Harga From produk", sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            return ds;

        }


        public int CreateNewProduct(Apps.Models.Product product)
        {
            int res;
            sqlConnection.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO produk (nama_produk, jumlah, jenis_satuan, harga, created_by, creation_date) VALUES (@nama_produk,@jumlah,@jenis_satuan,@harga,@created_by,@creation_date)", sqlConnection);
            insertSQL.CommandType = CommandType.Text;
            insertSQL.Parameters.AddWithValue("@nama_produk", product.namaProduk);
            insertSQL.Parameters.AddWithValue("@jumlah", product.jumlah);
            insertSQL.Parameters.AddWithValue("@jenis_satuan", product.jenisSatuan);
            insertSQL.Parameters.AddWithValue("@harga", product.harga);
            insertSQL.Parameters.AddWithValue("@created_by", product.createdBy);
            insertSQL.Parameters.AddWithValue("@creation_date", product.creationTime);

            try
            {
                res = insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            sqlConnection.Close();
            return res;
        }

        public DataSet GetQueryProduct(string query)
        {

            sqlConnection.Open();
            Console.WriteLine("Select id_produk as ID, nama_produk as Nama Produk, jumlah as Stock, jenis_satuan as Satuan, harga as Harga From products WHERE ID = '" + query + "' OR Nama LIKE '%" + query + "%'");
            string queryString = "Select id_produk as ID, nama_produk as Nama Produk, jumlah as Stock, jenis_satuan as Satuan, harga as Harga From products WHERE ID = '" + query + "' OR Nama LIKE '%" + query + "%'";



            SQLiteDataAdapter adapter = new SQLiteDataAdapter(queryString, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");
            sqlConnection.Close();
            return ds;

        }

        public int UpdateProductStock(int stock,string idProduk) {
            int result;
            sqlConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sqlConnection);
            command.CommandText =
            "update Example set jumlah = :jumlah where id_produk=:id";
            command.Parameters.Add("jumlah", DbType.String).Value = stock;
            command.Parameters.Add("id_produk", DbType.String).Value = idProduk;
            result = command.ExecuteNonQuery();
            return result;

        }

        //Purchase related functions

        public DataSet GetAllPurchase()
        {
            sqlConnection.Open();
            string sqlString = "select invoice_no as [Invoice No], tujuan as Supplier, tgl_invoice as [Tgl Pembelian] from pembelian";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlString, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");

            DataSet newDs = new DataSet();
            sqlConnection.Close();
            return ds;
        }

        public DataSet GetAllRelatedProductPurchase(string invoiceNo) {
            sqlConnection.Open();
            string sqlStr = "select produk.nama_produk  as [Nama Produk], detail_pembelian.kuantitas as Qty, produk.jenis_satuan as Satuan, detail_pembelian.harga_produk as [@], detail_pembelian.diskon as Diskon,(detail_pembelian.kuantitas * detail_pembelian.harga_produk )- detail_pembelian.diskon as Jumlah from detail_pembelian  INNER JOIN produk ON detail_pembelian.id_produk = produk.id_produk WHERE detail_pembelian.invoice_no = '" + invoiceNo + "'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlStr, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");

            DataSet newDs = new DataSet();
            sqlConnection.Close();
            return ds;
        }

        public bool CreateNewPurchase(Apps.Models.Transaction transaction)
        {
            int res = 0;
            sqlConnection.Open();

            //command to insert to table pembelian
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO pembelian (invoice_no,tujuan, tgl_invoice, biaya_kirim, created_by, creation_time) VALUES (@invoice_no,@tujuan,@tgl_invoice,@biaya_kirim,@created_by,@creation_date)", sqlConnection);
            insertSQL.CommandType = CommandType.Text;
            insertSQL.Parameters.AddWithValue("@invoice_no", transaction.invoice_no);
            insertSQL.Parameters.AddWithValue("@tujuan", transaction.tujuan);
            insertSQL.Parameters.AddWithValue("@tgl_invoice", transaction.tgl_invoice);
            insertSQL.Parameters.AddWithValue("@biaya_kirim", transaction.biaya_kirim);
            insertSQL.Parameters.AddWithValue("@created_by", transaction.createdBy);
            insertSQL.Parameters.AddWithValue("@creation_date", transaction.creationTime);

            try
            {
                res += insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //command to insert to table detail pembelian
            foreach (Apps.Models.Product p in transaction.produkList) {
                SQLiteCommand insertInnerSQL = new SQLiteCommand("INSERT INTO detail_pembelian (invoice_no,id_produk, harga_produk, kuantitas, diskon) VALUES (@invoice_no,@id_produk,@harga_produk,@kuantitas,@diskon)", sqlConnection);
                insertInnerSQL.CommandType = CommandType.Text;
                insertInnerSQL.Parameters.AddWithValue("@invoice_no", transaction.invoice_no);
                insertInnerSQL.Parameters.AddWithValue("@id_produk", p.idProduk);
                insertInnerSQL.Parameters.AddWithValue("@harga_produk", p.harga);
                insertInnerSQL.Parameters.AddWithValue("@kuantitas", p.jumlah);
                insertInnerSQL.Parameters.AddWithValue("@diskon", p.diskon);

                SQLiteCommand command = new SQLiteCommand(sqlConnection);
                command.CommandText =
                "update produk set jumlah = jumlah+@jumlah where id_produk=@id";
                command.Parameters.Add("@jumlah", DbType.String).Value = p.jumlah;
                command.Parameters.Add("@id", DbType.String).Value = p.idProduk;
                res = command.ExecuteNonQuery();

                try
                {
                    res += insertInnerSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }

            sqlConnection.Close();
            return res==(1+(transaction.produkList.Count*2));
        }

        //Purchase related functions

        public DataSet GetAllSell()
        {
            sqlConnection.Open();
            string sqlString = "select invoice_no as [Invoice No], supplier as Customer, tgl_invoice as [Tgl Penjualan] from penjualan";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlString, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");

            DataSet newDs = new DataSet();
            sqlConnection.Close();
            return ds;
        }

        public DataSet GetAllRelatedProductSell(string invoiceNo)
        {
            sqlConnection.Open();
            string sqlStr = "select produk.nama_produk  as [Nama Produk], detail_penjualan.kuantitas as Qty, produk.jenis_satuan as Satuan, detail_penjualan.harga_produk as [@], detail_penjualan.diskon as Diskon,(detail_penjualan.kuantitas * detail_penjualan.harga_produk )- detail_penjualan.diskon as Jumlah from detail_penjualan  INNER JOIN produk ON detail_penjualan.id_produk = produk.id_produk WHERE detail_penjualan.invoice_no = '" + invoiceNo + "'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlStr, sqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Info");

            DataSet newDs = new DataSet();
            sqlConnection.Close();
            return ds;
        }

        public bool CreateNewSell(Apps.Models.Transaction transaction)
        {
            int res = 0;
            sqlConnection.Open();

            //command to insert to table penjualan
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO penjualan (invoice_no,supplier, tgl_invoice, deskripsi, biaya_kirim, created_by, creation_time) VALUES (@invoice_no,@tujuan,@tgl_invoice,@deskripsi,@biaya_kirim,@created_by,@creation_date)", sqlConnection);
            insertSQL.CommandType = CommandType.Text;
            insertSQL.Parameters.AddWithValue("@invoice_no", transaction.invoice_no);
            insertSQL.Parameters.AddWithValue("@tujuan", transaction.tujuan);
            insertSQL.Parameters.AddWithValue("@tgl_invoice", transaction.tgl_invoice);
            insertSQL.Parameters.AddWithValue("@deskripsi", transaction.deskripsi);
            insertSQL.Parameters.AddWithValue("@biaya_kirim", transaction.biaya_kirim);
            insertSQL.Parameters.AddWithValue("@created_by", transaction.createdBy);
            insertSQL.Parameters.AddWithValue("@creation_date", transaction.creationTime);

            try
            {
                res += insertSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //command to insert to table detail penjualan 
            foreach (Apps.Models.Product p in transaction.produkList)
            {
                SQLiteCommand insertInnerSQL = new SQLiteCommand("INSERT INTO detail_penjualan (invoice_no,id_produk, harga_produk, kuantitas, diskon) VALUES (@invoice_no,@id_produk,@harga_produk,@kuantitas,@diskon)", sqlConnection);
                insertInnerSQL.CommandType = CommandType.Text;
                insertInnerSQL.Parameters.AddWithValue("@invoice_no", transaction.invoice_no);
                insertInnerSQL.Parameters.AddWithValue("@id_produk", p.idProduk);
                insertInnerSQL.Parameters.AddWithValue("@harga_produk", p.harga);
                insertInnerSQL.Parameters.AddWithValue("@kuantitas", p.jumlah);
                insertInnerSQL.Parameters.AddWithValue("@diskon", p.diskon);

                SQLiteCommand command = new SQLiteCommand(sqlConnection);
                command.CommandText =
                "update produk set jumlah = jumlah-@jumlah where id_produk=@id";
                command.Parameters.Add("@jumlah", DbType.String).Value = p.jumlah;
                command.Parameters.Add("@id", DbType.String).Value = p.idProduk;
                res = command.ExecuteNonQuery();

                try
                {
                    res += insertInnerSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }

            sqlConnection.Close();
            return res == (1 + (transaction.produkList.Count * 2));
        }


        public bool login(string username, string password)
        {
            sqlConnection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select password FROM users WHERE username = '" + username.ToLower() + "'", sqlConnection);
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
