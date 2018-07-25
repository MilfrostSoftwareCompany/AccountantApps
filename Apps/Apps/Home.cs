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
        public static int widthPanel,heightPanel;

        public Home()
        {
            InitializeComponent();
            InitializeDesign();
        }
        public void InitializeDesign()
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            //Console.WriteLine("width  = " + this.Width);
            //Console.WriteLine("height  = " + this.Height);
            //widthPanel = Convert.ToInt32(this.Width * 0.85);
            //heightPanel = Convert.ToInt32(this.Height * 0.97);
            ////sidePanel
            //sidePanel.Width = Convert.ToInt32(this.Width * 0.15);
            //sidePanel.Height = Convert.ToInt32(this.Height);
            //sidePanel.Location = new Point(0, 0);
            ////pointer
            //pointer.Height = supplier.Height;
            //pointer.Top = supplier.Top;
            ////topPanel
            ////topPanel.Width = Convert.ToInt32(this.Width);
            ////topPanel.Height = Convert.ToInt32(this.Height * 0.03);
            ////topPanel.Location = new Point(sidePanel.Width, 0);
            ////supplier
            //supplier.Width = sidePanel.Width;
            //supplier.BackColor = Color.FromArgb(255, 50, 50, 50);
            //supplier.Location = new Point(0, Convert.ToInt32(this.Height * 0.03));
            ////pelanggan
            //pelanggan.Width = sidePanel.Width;
            //pelanggan.BackColor = Color.FromArgb(255, 30, 30, 30);
            //pelanggan.Location = new Point( 0, supplier.Top + supplier.Height + Convert.ToInt32(this.Height*0.03));
            ////inventori
            //inventori.Width = sidePanel.Width;
            //inventori.BackColor = Color.FromArgb(255, 30, 30, 30);
            //inventori.Location = new Point(0, pelanggan.Top + pelanggan.Height + Convert.ToInt32(this.Height * 0.03));
            ////pembelian
            //pembelian.Width = sidePanel.Width;
            //pembelian.BackColor = Color.FromArgb(255, 30, 30, 30);
            //pembelian.Location = new Point(0, inventori.Top + inventori.Height + Convert.ToInt32(this.Height * 0.03));
            ////penjualan
            //penjualan.Width = sidePanel.Width;
            //penjualan.BackColor = Color.FromArgb(255, 30, 30, 30);
            //penjualan.Location = new Point(0, pembelian.Top + pembelian.Height + Convert.ToInt32(this.Height * 0.03));
            ////pengaturan
            //pengaturan.Width = sidePanel.Width;
            //pengaturan.BackColor = Color.FromArgb(255, 30, 30, 30);
            //pengaturan.Location = new Point(0, penjualan.Top + penjualan.Height + Convert.ToInt32(this.Height * 0.03));
            ////panel supplier
            //supplier1.Location = new Point(sidePanel.Width,topPanel.Height);
            //supplier1.Width = widthPanel;
            //supplier1.Height = heightPanel;
            ////panel pelanggan
            //customer1.Location = new Point(sidePanel.Width, topPanel.Height);
            //customer1.Width = widthPanel;
            //customer1.Height = heightPanel;
            ////panel inventori
            //inventori1.Location = new Point(sidePanel.Width, topPanel.Height);
            //inventori1.Width = widthPanel;
            //inventori1.Height = heightPanel;
            ////panel pembelian
            //pembelian1.Location = new Point(sidePanel.Width, topPanel.Height);
            //pembelian1.Width = widthPanel;
            //pembelian1.Height = heightPanel;
            ////panel penjualan
            //penjualan1.Location = new Point(sidePanel.Width, topPanel.Height);
            //penjualan1.Width = widthPanel;
            //penjualan1.Height = heightPanel;
            ////panel pengaturan
            //pengaturan1.Location = new Point(sidePanel.Width, topPanel.Height);
            //pengaturan1.Width = widthPanel;
            //pengaturan1.Height = heightPanel;
            //panel yang ditampilkan
            supplier1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MENU SUPPLIER
            pointer.Height = supplier.Height;
            pointer.Top = supplier.Top;
            supplier.BackColor = Color.FromArgb(255, 50, 50, 50);
            pelanggan.BackColor = Color.FromArgb(255, 30, 30, 30);
            inventori.BackColor = Color.FromArgb(255, 30, 30, 30);
            pembelian.BackColor = Color.FromArgb(255, 30, 30, 30);
            penjualan.BackColor = Color.FromArgb(255, 30, 30, 30);
            pengaturan.BackColor = Color.FromArgb(255, 30, 30, 30);

            supplier1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MENU PELANGGAN
            pointer.Height = pelanggan.Height;
            pointer.Top = pelanggan.Top;
            pelanggan.BackColor = Color.FromArgb(255, 50, 50, 50);
            supplier.BackColor = Color.FromArgb(255, 30, 30, 30);
            inventori.BackColor = Color.FromArgb(255, 30, 30, 30);
            pembelian.BackColor = Color.FromArgb(255, 30, 30, 30);
            penjualan.BackColor = Color.FromArgb(255, 30, 30, 30);
            pengaturan.BackColor = Color.FromArgb(255, 30, 30, 30);

            customer1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MENU INVENTORI
            pointer.Height = inventori.Height;
            pointer.Top = inventori.Top;
            inventori.BackColor = Color.FromArgb(255, 50, 50, 50);
            supplier.BackColor = Color.FromArgb(255, 30, 30, 30);
            pelanggan.BackColor = Color.FromArgb(255, 30, 30, 30);
            pembelian.BackColor = Color.FromArgb(255, 30, 30, 30);
            penjualan.BackColor = Color.FromArgb(255, 30, 30, 30);
            pengaturan.BackColor = Color.FromArgb(255, 30, 30, 30);

            inventori1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MENU PEMBELIAN
            pointer.Height = pembelian.Height;
            pointer.Top = pembelian.Top;
            pembelian.BackColor = Color.FromArgb(255, 50, 50, 50);
            supplier.BackColor = Color.FromArgb(255, 30, 30, 30);
            pelanggan.BackColor = Color.FromArgb(255, 30, 30, 30);
            inventori.BackColor = Color.FromArgb(255, 30, 30, 30);
            penjualan.BackColor = Color.FromArgb(255, 30, 30, 30);
            pengaturan.BackColor = Color.FromArgb(255, 30, 30, 30);

            beliPanel.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MENU PENJUALAN
            pointer.Height = penjualan.Height;
            pointer.Top = penjualan.Top;
            penjualan.BackColor = Color.FromArgb(255, 50, 50, 50);
            supplier.BackColor = Color.FromArgb(255, 30, 30, 30);
            pelanggan.BackColor = Color.FromArgb(255, 30, 30, 30);
            inventori.BackColor = Color.FromArgb(255, 30, 30, 30);
            pembelian.BackColor = Color.FromArgb(255, 30, 30, 30);
            pengaturan.BackColor = Color.FromArgb(255, 30, 30, 30);

            penjualan1.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MENU PENGATURAN
            pointer.Height = pengaturan.Height;
            pointer.Top = pengaturan.Top;
            pengaturan.BackColor = Color.FromArgb(255, 50, 50, 50);
            supplier.BackColor = Color.FromArgb(255, 30, 30, 30);
            pelanggan.BackColor = Color.FromArgb(255, 30, 30, 30);
            inventori.BackColor = Color.FromArgb(255, 30, 30, 30);
            pembelian.BackColor = Color.FromArgb(255, 30, 30, 30);
            penjualan.BackColor = Color.FromArgb(255, 30, 30, 30);

            pengaturan1.BringToFront();
        }

    }
}
