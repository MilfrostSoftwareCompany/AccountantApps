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
    public partial class supplier : UserControl
    {
        public supplier()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_supplier1.BringToFront();
        }
        private void supplier2_Load(object sender, EventArgs e)
        {
 
        }

        private void supplier_Load(object sender, EventArgs e)
        {

        }
    }
}
