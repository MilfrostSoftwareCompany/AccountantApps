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
    public partial class Pengaturan : UserControl
    {
        public Pengaturan()
        {
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeComponent();
            InitializeDesign();
        }
        public void InitializeDesign()
        {
            //username.Location = new Point(15,15);
            //gantiPassword.Location = new Point(15,username.Height+30);
            //labelNamaToko.Location = new Point(15, gantiPassword.Height + username.Height + 47);
            //namaToko.Location = new Point(labelNamaToko.Width+30, gantiPassword.Height + username.Height + 45);
            //buttonSave.Location = new Point(labelNamaToko.Width +namaToko.Width+ 45, gantiPassword.Height + username.Height + 43);
            //labelDaftarPemakai.Location = new Point(15,username.Height+gantiPassword.Height+labelNamaToko.Height+75);
            //tabelPemakai.Location = new Point(15, username.Height + gantiPassword.Height + labelNamaToko.Height + labelDaftarPemakai.Height + 90);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ganti_Password FormGantiPassword = new Ganti_Password();
            FormGantiPassword.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (namaToko.Text.Length == 0)
            {
                MessageBox.Show("Harus mengisi field Nama Toko !!");
            }
            else
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        }
    }
}
