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
    public partial class frmUsers : Form
    {
        UserManager  userManager = new UserManager();

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            var allUsers = userManager.GetAll();
            grUsers.DataSource = allUsers;
        }
    }
}
