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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Customer FormAddCustomer = new Add_Customer();
            FormAddCustomer.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Add_Customer FormAddCustomer = new Add_Customer();
            FormAddCustomer.ShowDialog();
        }
    }
}
