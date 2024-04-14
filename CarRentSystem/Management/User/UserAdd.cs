using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentSystem.CarRentSystemDataSetTableAdapters;

namespace CarRentSystem.Management.User
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = namaTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            int level = karyawanRadio.Checked ? 2 : 1;

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
                    int result = usersTableAdapter.InsertQuery(name, username, password, level);

                    if (result == 1)
                    {
                        MessageBox.Show("Data berhasil ditambahkan!", "Berhasil", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Terjadi kesalahan, data gagal ditambahkan", "Gagal", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
