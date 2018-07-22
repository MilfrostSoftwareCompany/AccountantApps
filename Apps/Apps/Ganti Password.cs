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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passLama.Text.Length == 0 || passBaru.Text.Length == 0 || konfirmasiPass.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
            }
            else if (passBaru.Text != konfirmasiPass.Text)
            {
                MessageBox.Show("Password Baru dan Konfirmasi Password tidak sama !!");
            }
            else {
                this.Close();
            }
        }
    }
}
