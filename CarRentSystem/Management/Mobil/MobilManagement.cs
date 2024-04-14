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
using CarRentSystem.CarRentSystemDataSetTableAdapters;

namespace CarRentSystem.Management.Mobil
{
    public partial class MobilManagement : Form
    {
        DataTable carsTable = new DataTable();
        private int dataIndex;
        private double pageNumber;
        private int currentPage = 1;

        private List<int> cardIds = new List<int>();

        private string searchQuery;
        public MobilManagement()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                cardIds.Add(i);
            }
            Get_Cars();
            Fill_Data();
        }

        private void Get_Cars()
        {
            carsTable = carsTableAdapter.GetDataWithFilter($"%{searchQuery}%");
            pageNumber = Math.Ceiling(Convert.ToDouble(carsTable.Rows.Count) / 3);
        }

        private void Fill_Data()
        {
            dataCard1.Visible = false;
            dataCard2.Visible = false;
            dataCard3.Visible = false;

            int dataCardNumber = 1;

            if (carsTable.Rows.Count > 0)
            {
                for (int i = dataIndex; i < dataIndex + 3; i++)
                {
                    var dataCard = Controls.Find("dataCard" + dataCardNumber, true).FirstOrDefault() as Panel;
                    var pictureBox = Controls.Find("pictureBox" + dataCardNumber, true).FirstOrDefault() as PictureBox;
                    var carDataLabel = Controls.Find("carDataLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var plateNumber = Controls.Find("plateLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var rentalPrice = Controls.Find("priceLabel" + dataCardNumber, true).FirstOrDefault() as Label;

                    if (i < carsTable.Rows.Count)
                    {
                        dataCard.Visible = true;
                        pictureBox.Image = DBNull.Value.Equals(carsTable.Rows[i]["image"]) ? Properties.Resources.no_image : Display_Image((byte[])carsTable.Rows[i]["image"]);
                        carDataLabel.Text = $"{carsTable.Rows[i]["brand"]} {carsTable.Rows[i]["year"]} {carsTable.Rows[i]["color"]}";
                        plateNumber.Text = $"{carsTable.Rows[i]["plate"]}";
                        rentalPrice.Text = $"{carsTable.Rows[i]["rental_price"]}";

                        cardIds[dataCardNumber] = Convert.ToInt32(carsTable.Rows[i]["car_id"]);

                        dataCardNumber++;
                    }
                }
            }
            if (currentPage == 1)
            {
                prevButton.Enabled = false;
            }
            else
            {
                prevButton.Enabled = true;
            }

            if (currentPage == pageNumber)
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
        }

        private Image Display_Image(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            dataIndex += 3;
            currentPage++;
            Fill_Data();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            dataIndex -= 3;
            currentPage--;
            Fill_Data();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            MobilAdd mobilAdd = new MobilAdd();
            mobilAdd.ShowDialog();
            Get_Cars();
            Fill_Data();
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            MobilEdit mobilEdit = new MobilEdit(cardIds[1]);
            mobilEdit.ShowDialog();
            Get_Cars();
            Fill_Data();
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            MobilEdit mobilEdit = new MobilEdit(cardIds[2]);
            mobilEdit.ShowDialog();
            Get_Cars();
            Fill_Data();
        }

        private void editButton3_Click(object sender, EventArgs e)
        {
            MobilEdit mobilEdit = new MobilEdit(cardIds[3]);
            mobilEdit.ShowDialog();
            Get_Cars();
            Fill_Data();
        }

        private void trashButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                carsTableAdapter.DeleteQuery(cardIds[1]);
                Get_Cars();
                Fill_Data();
            }
        }

        private void trashButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                carsTableAdapter.DeleteQuery(cardIds[2]);
                Get_Cars();
                Fill_Data();
            }
        }

        private void trashButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                carsTableAdapter.DeleteQuery(cardIds[3]);
                Get_Cars();
                Fill_Data();
            }
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchQuery = searchBar.Text;
                dataIndex = 0;
                currentPage = 1;
                Get_Cars();
                Fill_Data();
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            searchQuery = "";
            searchBar.Text = string.Empty;
            dataIndex = 0;
            currentPage = 1;
            Get_Cars();
            Fill_Data();
        }
    }
}
