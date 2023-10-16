using ClothesStoreManagementSystem.Models;
using ClothesStoreManagementSystem.Operations.Concrete;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var userModel = new User();
            userModel.ID = userManager.GetNextId();
            userModel.Username = username;
            userModel.Password = password;

            

            var result =  userManager.Add(userModel);

            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message);
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
                txtPassword.Text = string.Empty;
                txtUsername.Text = string.Empty;
            }
        }
    }
}
