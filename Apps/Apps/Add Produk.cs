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
    public partial class Add_Produk : Form
    {
        public Add_Produk()
        {         
            InitializeComponent();
            InitializeDesign();
        }

        public void InitializeDesign()
        {
            labelIdBarang.Location = new Point(15, 15);
            comboBoxIdBarang.Location = new Point(Convert.ToInt32(labelIdBarang.Width) + 55, 15);
            labelStokBarang.Location = new Point(15, Convert.ToInt32(labelIdBarang.Height) + 30);
            StokBarang.Location = new Point(Convert.ToInt32(labelStokBarang.Width) + 30, Convert.ToInt32(labelIdBarang.Height) + 28);
            buttonSave.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonSave.Width) - 30, Convert.ToInt32(this.Height) - Convert.ToInt32(buttonSave.Height) - 60);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxIdBarang.Text.Length == 0 || StokBarang.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
            }
            else
            {
                this.Close();
            }
        }
    }
}
