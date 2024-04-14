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
    public partial class CarSeatEdit : Form
    {
        private string name;
        private int carSeatId;
        private DataRow carSeatData;
        public CarSeatEdit(int id)
        {
            InitializeComponent();
            this.carSeatId = id;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            name = namaTextBox.Text;

            if (name == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan!", MessageBoxButtons.OK);
            }
            else
            {
                int result = carseatTableAdapter.UpdateQuery(name, carSeatId);
                if (result == 1)
                {
                    MessageBox.Show("Data berhasil diubah!", "Berhasil", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Terjadi kesalahan, data gagal ditambahkan", "Gagal", MessageBoxButtons.OK);
                }
            }
        }

        private void CarSeatEdit_Load(object sender, EventArgs e)
        {
            carSeatData = carseatTableAdapter.GetDataById(carSeatId).Rows[0];
            namaTextBox.Text = carSeatData["name"].ToString();
        }
    }
}
