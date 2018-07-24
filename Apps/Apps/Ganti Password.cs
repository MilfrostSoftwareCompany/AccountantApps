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
    public partial class Ganti_Password : Form
    {
        public Ganti_Password()
        {
            InitializeComponent();
            passLama.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (passLama.Text.Length == 0 || passBaru.Text.Length == 0 || konfirmasiPass.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
                if (passLama.Text.Length == 0) { passLama.Focus(); }
                else if (passBaru.Text.Length == 0) { passBaru.Focus(); }
                else { konfirmasiPass.Focus(); }
            }
            else if (passBaru.Text != konfirmasiPass.Text)
            {
                MessageBox.Show("Password Baru dan Konfirmasi Password tidak sama !!");
                passBaru.Focus();                
            }
            else
            {
                this.Close();
            }
        }
    }
}
