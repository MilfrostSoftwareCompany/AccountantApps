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
        Models.Customer customer_;
        bool isEdit = false;
        public Add_Customer( Customer customer)
        {
            InitializeComponent();
            this.customer = customer;

            nama.Focus();
        }

        public Add_Customer(Customer customer,Models.Customer customer_)
        {
            InitializeComponent();
            this.customer = customer;
            this.customer_ = customer_;
            isEdit = true;
            nama.Focus();
            SetViews();
            
        }

        private void SetViews()
        {
            nama.Text = customer_.nama;
            alamat.Text = customer_.alamat;
            telp.Text = customer_.telepon;
            buttonAddCustomer.Text = "Save";
        }

        private bool validateInt(string text) {
            bool result = true;
            for (int i = 0; i < text.Length; i++) {
                if (!Char.IsDigit(text[i])) {
                    result = false;
                    return result;
                }
            }
            return result;
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
            else if (!validateInt(telp.Text))
            {
                MessageBox.Show("Field Telepon harus diisi dengan angka !!");
                telp.Focus();
            }
            else
            {
                if (isEdit) {
                    Models.Customer customer__ = new Models.Customer(customer_.id, nama.Text, alamat.Text, telp.Text);
                    Database.getInstance().UpdateCustomer(customer__);
                    customer.EditCustomer(customer__);
                }
                else {
                    Models.Customer customer__ = new Apps.Models.Customer(nama.Text, alamat.Text, telp.Text);
                    int num = Database.getInstance().CreateNewCustomer(customer__);

                    customer__.id = Convert.ToString(num);
                    customer.AddCustomer(customer__);
                }
                this.Close();
            }
        }

        private void nama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
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
                buttonAddCustomer.PerformClick();
            }
        }

        private void telp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
