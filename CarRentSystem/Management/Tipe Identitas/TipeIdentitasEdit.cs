using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSystem.Management.Tipe_Identitas
{
    public partial class TipeIdentitasEdit : Form
    {
        private string name;
        private int tipeIdentitasId;
        private DataRow TipeIdentitasData;
        public TipeIdentitasEdit(int id)
        {
            InitializeComponent();
            tipeIdentitasId = id;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TipeIdentitasEdit_Load(object sender, EventArgs e)
        {
            TipeIdentitasData = identity_typeTableAdapter.GetDataById(tipeIdentitasId).Rows[0];
            name = TipeIdentitasData["name"].ToString();
            namaTextBox.Text = name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            name = namaTextBox.Text;

            if (name == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatn", MessageBoxButtons.OK);
            }
            else
            {
                int result = identity_typeTableAdapter.UpdateQuery(name, tipeIdentitasId);
                if (result == 1)
                {
                    MessageBox.Show("Data berhasil diubah!", "Berhasil!", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan!", "Peringatan!", MessageBoxButtons.OK);
                }
            }
        }
    }
}
