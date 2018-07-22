using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Add_Supplier : Form
    {
        Supplier supplier;

        public Add_Supplier(Supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nama.Text.Length == 0 || alamat.Text.Length == 0 || telp.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
            }
            else
            {
                this.Close();
            }

<<<<<<< HEAD
=======

            int num = Database.getInstance().CreateNewSupplier(new Apps.Models.Supplier(nama, alamat, telepon));
            supplier.refreshData();
            MessageBox.Show(""+num);
            //this.Close();
>>>>>>> 013c7cee85f1178dea18e5aa8cef32099e95dd65
        }
    }
}
