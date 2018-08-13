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
            textBoxUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Username / Password yang anda masukkan salah.");
            }
            else {
                String username = textBoxUsername.Text.ToLower().Trim();
                String password = textBoxPassword.Text;
                if (Database.getInstance().login(username, password))
                {
                    this.Hide();
                    Database.getInstance().updateLastLoginForUser(username);
                    Home home = new Home(username);
                    home.Show();
                    loggedUser = username;

                }
                else {
                    MessageBox.Show("Username / Password yang anda masukkan salah.");
                }               
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn.PerformClick();
            }
        }
    }
}
