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
    public partial class Add_Customer : Form
    {
        Customer customer;
        public Add_Customer( Customer customer)
        {
            InitializeComponent();
            this.customer = customer;

            nama.Focus();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
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
                int num = Database.getInstance().CreateNewCustomer(new Apps.Models.Customer(nama.Text, alamat.Text, telp.Text));
                customer.refreshData();
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
            if (e.KeyCode == Keys.Enter) {
                nama.Focus();
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
                buttonAddCustomer.PerformClick();
            }
        }
    }
}
