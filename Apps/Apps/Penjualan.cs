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
    public partial class Penjualan : UserControl
    {
        public Penjualan()
        {
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeComponent();
            InitializeDesign();
        }

        public void InitializeDesign() {
            search.Location = new Point(15, 13);
            buttonSearch.Location = new Point(Convert.ToInt32(search.Width) + 30, 10);
            buttonAddPenjualan.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddPenjualan.Width) - 15, 10);
            tabelPenjualan.Width = Convert.ToInt32(this.Width - 30);
            tabelPenjualan.Height = Convert.ToInt32(this.Height) - Convert.ToInt32(buttonSearch.Height) - 50;
            tabelPenjualan.Location = new Point(15, Convert.ToInt32(buttonSearch.Height) + 30);
        }
        private void button2_Click(object sender, EventArgs e)
        {       
            Add_Penjualan FormAddPenjualan = new Add_Penjualan();
            FormAddPenjualan.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi field pencarian !!");
            }
            else
            {

            }
        }
    }
}
