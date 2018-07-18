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
    public partial class Supplier : UserControl
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Supplier FormAddSupplier = new Add_Supplier();
            FormAddSupplier.ShowDialog();
        }
    }
}
