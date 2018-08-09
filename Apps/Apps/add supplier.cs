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

            nama.Focus();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            if (nama.Text.Length == 0 || alamat.Text.Length == 0 || telp.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
                if (nama.Text.Length == 0) { nama.Focus(); }
                else if (alamat.Text.Length == 0) { alamat.Focus(); }
                else { telp.Focus(); }
            }
            else
            {
                int num = Database.getInstance().CreateNewSupplier(new Apps.Models.Supplier(nama.Text, alamat.Text, telp.Text));
                //supplier.refreshData();
                if (num == 1)
                {
                    MessageBox.Show("Data supplier telah di tambahkan");
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data supplier");
                }
                this.Close();
            }
        }

        private void nama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                alamat.Focus();
            }
        }

        private void alamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                telp.Focus();
            }
        }

        private void telp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddSupplier.PerformClick();
            }
        }

    }
}
