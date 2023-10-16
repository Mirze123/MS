using ClothesStoreManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesStoreManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToLower();
            string password = txtPassword.Text;

            var existingUser = Database.Users.SingleOrDefault(x => x.Username.ToLower() == username && CryptingHelper.Decrypt(x.Password) == password);

            if (existingUser != null)
            {
                MessageBox.Show("Login successfull");
                frmUsers frmUsers = new frmUsers();
                frmUsers.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();
        }
    }
}
