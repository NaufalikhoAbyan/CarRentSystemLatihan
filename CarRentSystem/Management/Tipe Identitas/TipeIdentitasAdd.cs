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
    public partial class TipeIdentitasAdd : Form
    {
        public TipeIdentitasAdd()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string nama = namaTextBox.Text;

            if (nama == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatn", MessageBoxButtons.OK);
            }
            else
            {
                int result = identity_typeTableAdapter.InsertQuery(nama);
                if (result == 1)
                {
                    MessageBox.Show("Data berhasil ditambahakan!", "Berhasil!", MessageBoxButtons.OK);
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
