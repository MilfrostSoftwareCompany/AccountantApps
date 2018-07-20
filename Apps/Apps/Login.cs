using Apps.Classes;
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
    public partial class Login : Form
    {
        public static string loggedUser;

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Username / Password yang anda masukkan salah.");
            }
            else {
                String username = textBox1.Text.ToLower().Trim();
                String password = textBox2.Text;
                if (Database.getInstance().login(username, password))
                {
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                    loggedUser = username;

                }
                else {
                    MessageBox.Show("Username / Password yang anda masukkan salah.");
                }
                
            }
        }
    }
}
