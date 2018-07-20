using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Pengaturan : UserControl
    {
        public Pengaturan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ganti_Password FormGantiPassword = new Ganti_Password();
            FormGantiPassword.ShowDialog();
        }
    }
}
