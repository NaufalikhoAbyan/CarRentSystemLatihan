using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSystem.Management.CarSeat
{
    public partial class CarSeatAdd : Form
    {
        public CarSeatAdd()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = namaTextBox.Text;

            if (name == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan!", MessageBoxButtons.OK);
            }
            else
            {
                int result = carseatTableAdapter.InsertQuery(name);
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
