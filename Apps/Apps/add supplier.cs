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
        Models.Supplier supplier_;
        Supplier supplier;
        bool isEdit = false;
        public Add_Supplier(Supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;

            nama.Focus();
        }
        public Add_Supplier(Supplier supplier,Models.Supplier supplier_)
        {
            
            InitializeComponent();
            this.supplier = supplier;
            this.supplier_ = supplier_;
            setView();
            isEdit = true;
            nama.Focus();
        }

        private void setView()
        {
            nama.Text = supplier_.nama;
            alamat.Text = supplier_.alamat;
            telp.Text = supplier_.telepon;
            buttonAddSupplier.Text = "SAVE";
        }

        private bool validateInt(string text)
        {
            bool result = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsDigit(text[i]))
                {
                    result = false;
                    return result;
                }
            }
            return result;
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
            else if (!validateInt(telp.Text))
            {
                MessageBox.Show("Field Telepon harus diisi dengan angka !!");
                telp.Focus();
            }
            else
            {
                
                if (isEdit) {
                    Models.Supplier supplier__ = new Models.Supplier(supplier_.id, nama.Text, alamat.Text, telp.Text);
                    Database.getInstance().UpdateSupplier(supplier__);
                    supplier.EditSupplier(supplier__);
                }
                else
                {
                    int num = Database.getInstance().CreateNewSupplier(new Apps.Models.Supplier(nama.Text, alamat.Text, telp.Text));
                    //supplier.refreshData();
                    
                        MessageBox.Show("Data supplier telah di tambahkan");
                        supplier.AddSupplier(new Models.Supplier(Convert.ToString(num),nama.Text, alamat.Text, telp.Text));
                   
                    
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
