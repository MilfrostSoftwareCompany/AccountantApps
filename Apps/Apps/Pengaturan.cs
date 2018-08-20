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
        DataSet ds;
        DataSet pemakaiDs;

        public static string namaToko1, alamatToko1;

        public Pengaturan()
        {
            this.Width = Home.widthPanel;
            this.Height = Home.heightPanel;
            InitializeComponent();
            InitializeDesign();
        }
        public void InitializeDesign()
        {
            pemakaiDs = Database.getInstance().GetAllUsers();
            tabelPemakai.DataSource = pemakaiDs.Tables[0];

            ds = Database.getInstance().GetCompanyDetails();
            namaToko.Text = ds.Tables[0].Rows[0][1].ToString();
            namaToko1 = namaToko.Text;
            richTextBox1.Text = ds.Tables[0].Rows[0][2].ToString();
            alamatToko1 = richTextBox1.Text;
            username.Text = Home.loggedUser_;
            Console.WriteLine(username.Text);
            Console.WriteLine(Home.loggedUser_);

            tabelPemakai.RowHeadersVisible = false;
            tabelPemakai.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (Login.permissionlvl == 1)
            {
                label1.Visible = true;
                tabelPemakai.Visible = true;
            }
            else {
                label1.Visible = false;
                tabelPemakai.Visible = false;
                namaToko.Enabled = false;
                richTextBox1.Enabled = false;
                buttonSave.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ganti_Password FormGantiPassword = new Ganti_Password();
            FormGantiPassword.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (namaToko.Text.Length == 0 || richTextBox1.Text.Length ==0)
            {
                MessageBox.Show("Harus mengisi field Nama & Alamat Toko !!");
            }
            else
            {
                Database.getInstance().UpdateCompanyData(namaToko.Text, richTextBox1.Text);
                MessageBox.Show("Data telah diupdate");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        }
    }
}
