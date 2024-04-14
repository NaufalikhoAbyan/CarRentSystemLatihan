using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSystem.Management.User
{
    public partial class UserEdit : Form
    {
        private int userId;
        private DataRow userData;
        
        private string name;
        private string username;
        private string password;
        private int level;
        public UserEdit(int id)
        {
            InitializeComponent();
            userId = id;
            userData = usersTableAdapter.GetDataById(userId).Rows[0];
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            name = userData["name"].ToString();
            namaTextBox.Text = name;

            username = userData["username"].ToString();
            usernameTextBox.Text = username;

            password = userData["password"].ToString();
            passwordTextBox.Text = password;

            if (Convert.ToInt32(userData["level"]) == 1)
            {
                adminRadio.Checked = true;
                level = 1;
            }
            else
            {
                karyawanRadio.Checked = true;
                level = 2;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            name = namaTextBox.Text;
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            level = adminRadio.Checked ? 1 : 2;

            if (name == "" || username == "" || password == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan!", MessageBoxButtons.OK);
            }
            else
            {
                if (password.Length < 8)
                {
                    MessageBox.Show("Minimal panjang password 8 karakter!", "Peringatan!", MessageBoxButtons.OK);
                }
                else
                {
                    int result = usersTableAdapter.UpdateQuery(name, username, password, level, userId);

                    if (result == 1)
                    {
                        MessageBox.Show("Data berhasil diubah!", "Berhasil", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Terjadi kesalahan, data gagal diubah", "Gagal", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
