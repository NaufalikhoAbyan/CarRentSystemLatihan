using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CarRentSystem.Settings
{
    public partial class ResetPassword : Form
    {
        private int userId;
        DataRow userData;
        public ResetPassword(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            if (oldPassword != userData["password"].ToString())
            {
                MessageBox.Show("Password lama tidak tepat!", "Peringatan!", MessageBoxButtons.OK);
            }
            else
            {
                if(newPassword != confirmPassword)
                {
                    MessageBox.Show("Konfirmasi password tidak tepat", "Peringatan!", MessageBoxButtons.OK);
                }
                else
                { 
                    int result = usersTableAdapter.UpdatePassword(newPassword, userId);
                    if(result == 1)
                    {
                        MessageBox.Show("Password berhasil diubah!", "Berhasil!", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Password gagal diubah!", "Peringatan!", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            userData = usersTableAdapter.GetDataById(userId).Rows[0];
        }
    }
}
