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
    public partial class MobilEdit : Form
    {
        private int carId;

        string brand;
        string plate;
        string color;
        string year;
        string rentalPrice;
        int carSeatId;
        int status;

        DataRow carData;
        public MobilEdit(int id)
        {
            InitializeComponent();
            carId = id;
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

        private void MobilEdit_Load(object sender, EventArgs e)
        {
            carData = carsTableAdapter.GetDataById(carId).Rows[0];

            List<CarSeat> carSeatIds = new List<CarSeat>();
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

            brand = carData["brand"].ToString();
            brandTextBox.Text = brand;

            plate = carData["plate"].ToString();
            plateTextBox.Text = plate;

            color = carData["color"].ToString();
            colorTextBox.Text = color;

            year = carData["year"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(year);

            rentalPrice = carData["rental_price"].ToString();
            rentalPriceTextBox.Text = rentalPrice;

            carSeatId = Convert.ToInt32(carData["car_seat_id"]);
            carSeatComboBox.SelectedValue = carSeatId;

            status = Convert.ToInt32(carData["status"]);
            if (status == 1)
            {
                tersediaRadio.Checked = true;
            }
            else
            {
                rentalRadio.Checked = true;
            }

            if (!DBNull.Value.Equals(carData["image"]))
            {
                pictureBox1.Image = Display_image((byte[])carData["image"]);
            }
        }

        private byte[] Save_Image(PictureBox pb)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.ToArray();
        }

        private Image Display_image(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            brand = brandTextBox.Text;
            plate = plateTextBox.Text;
            color = colorTextBox.Text;
            year = dateTimePicker1.Value.ToString();
            rentalPrice = rentalPriceTextBox.Text;
            carSeatId = Convert.ToInt32(carSeatComboBox.SelectedValue);
            status = tersediaRadio.Checked ? 1 : 2;

            if (brand == "" || plate == "" || color == "" || rentalPrice == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan!", MessageBoxButtons.OK);
            }
            else
            {
                int result = carsTableAdapter.UpdateQuery(brand, plate, color, year, status, rentalPrice, carSeatId, pictureBox1.Image != null ? Save_Image(pictureBox1) : null, carId);
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

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
