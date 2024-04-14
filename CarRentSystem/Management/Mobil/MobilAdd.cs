using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSystem.Management.Mobil
{
    public partial class MobilAdd : Form
    {
        public MobilAdd()
        {
            InitializeComponent();
        }

        private class CarSeat
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public CarSeat(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MobilAdd_Load(object sender, EventArgs e)
        {
            List<CarSeat> carSeatIds  =  new List<CarSeat>();
            DataTable carSeatTable = carseatTableAdapter.GetData();
            if (carSeatTable.Rows.Count > 0)
            {
                foreach (DataRow row in carSeatTable.Rows)
                {
                    int id = Convert.ToInt32(row["car_seat_id"]);
                    string name = row["name"].ToString();
                    carSeatIds.Add(new CarSeat(id, name));
                }
            }
            carSeatComboBox.DataSource = carSeatIds;
            carSeatComboBox.DisplayMember = "Name";
            carSeatComboBox.ValueMember = "Id";

            tersediaRadio.Checked = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string brand = brandTextBox.Text;
            string plate = plateTextBox.Text;
            string color = colorTextBox.Text;
            DateTime year = dateTimePicker1.Value;
            string rentalPrice = rentalPriceTextBox.Text;
            int carSeatId = Convert.ToInt32(carSeatComboBox.SelectedValue);
            int status = tersediaRadio.Checked ? 1 : 2;

            if (brand == "" || plate == "" || color == "" || rentalPrice == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan!", MessageBoxButtons.OK);
            }
            else
            {
                int result = carsTableAdapter.InsertQuery(brand, plate, color, year.ToString(), status, rentalPrice,
                    carSeatId, pictureBox1.Image != null ? Save_Image(pictureBox1) : null);
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

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private byte[] Save_Image(PictureBox pb)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.ToArray();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
