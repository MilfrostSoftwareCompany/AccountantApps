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
    public partial class View_Detail_Pembelian : Form
    {
        public View_Detail_Pembelian()
        {
            InitializeComponent();
        }

        private void buttonAddBarang_Click(object sender, EventArgs e)
        {
            Add_Barang FormAddBarang = new Add_Barang(this);
            FormAddBarang.ShowDialog();
        }
    }
}
