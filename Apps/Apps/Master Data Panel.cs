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
    public partial class Master_Data_Panel : UserControl
    {
        public Master_Data_Panel()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.BackColor = Color.FromArgb(255, 50, 50, 50);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.BackColor = Color.FromArgb(255, 50, 50, 50);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            button2.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            button3.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            button4.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button5.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            button5.BackColor = Color.FromArgb(255, 50, 50, 50);
            button1.BackColor = Color.FromArgb(255, 30, 30, 30);
            button2.BackColor = Color.FromArgb(255, 30, 30, 30);
            button3.BackColor = Color.FromArgb(255, 30, 30, 30);
            button4.BackColor = Color.FromArgb(255, 30, 30, 30);
        }


    }
}
