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
    public partial class Opname_Stock : Form
    {
        public Opname_Stock()
        {
            InitializeComponent();
            InitializeDesign();
        }

        public void InitializeDesign()
        {
            labelDariTgl.Location = new Point(15, 15);
            DariTgl.Location = new Point(Convert.ToInt32(labelDariTgl.Width)+55, 13);
            labelSampaiTgl.Location = new Point(15, Convert.ToInt32(labelDariTgl.Height)+30);
            SampaiTgl.Location = new Point(Convert.ToInt32(labelSampaiTgl.Width) + 30, Convert.ToInt32(labelDariTgl.Height) + 30);
            buttonAddProduk.Location = new Point(Convert.ToInt32(this.Width) - Convert.ToInt32(buttonAddProduk.Width) - 30, Convert.ToInt32(labelDariTgl.Height) + 30);
            buttonSave.Location = new Point(Convert.ToInt32(this.Width)-Convert.ToInt32(buttonSave.Width)-30,Convert.ToInt32(this.Height)-Convert.ToInt32(buttonSave.Height)-45);
            tabelOpname.Width = Convert.ToInt32(this.Width) - 45;
            tabelOpname.Height = Convert.ToInt32(this.Height) - Convert.ToInt32(labelDariTgl.Height) - Convert.ToInt32(labelSampaiTgl.Height)-Convert.ToInt32(buttonSave.Height) - 105;
            tabelOpname.Location = new Point(15, Convert.ToInt32(labelDariTgl.Height) + Convert.ToInt32(labelSampaiTgl.Height)+ 45);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (DariTgl.Text.Length == 0 || SampaiTgl.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi semua field !!");
            }
            else
            {
                this.Close();
            }
        }

        private void buttonAddProduk_Click(object sender, EventArgs e)
        {
            Add_Produk FormAddProduk = new Add_Produk();
            FormAddProduk.ShowDialog();
        }
    }
}
