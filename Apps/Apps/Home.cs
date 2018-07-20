using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.BackColor = Color.FromArgb(255, 50, 50, 50);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
            button6.BackColor = Color.FromArgb(255, 30, 30, 30);

            supplier1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MENU SUPPLIER
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.BackColor = Color.FromArgb(255, 50, 50, 50);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
            button6.BackColor = Color.FromArgb(255, 30, 30, 30);

            supplier1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MENU PELANGGAN
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            button2.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
            button6.BackColor = Color.FromArgb(255, 30, 30, 30);

            customer1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MENU INVENTORI
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            button3.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
            button6.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MENU PEMBELIAN
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            button4.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
            button6.BackColor = Color.FromArgb(255, 30, 30, 30);

            pembelian1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MENU PENJUALAN
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            button5.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button6.BackColor = Color.FromArgb(255, 30, 30, 30);

            penjualan1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MENU PENGATURAN
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            button6.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);

            pengaturan1.BringToFront();
        }

        private void supplier1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
