using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSystem.Login
{
    public partial class Login : Form
    {
        private DataTable loginData;
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            loginData = usersTableAdapter.LoginCheck(username, password);
            if (loginData.Rows.Count > 0)
            {
                MainForm mainForm = (MainForm)ParentForm;
                mainForm.Login_User(Convert.ToInt32(loginData.Rows[0]["user_id"]), Convert.ToInt32(loginData.Rows[0]["level"]));
            }
            else
            {
                MessageBox.Show("Login Gagal! Periksa lagi detail akun anda!", "Peringatan!", MessageBoxButtons.OK);
            }

        }
    }
}
