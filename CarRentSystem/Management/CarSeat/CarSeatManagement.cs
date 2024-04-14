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
    public partial class CarSeatManagement : Form
    {
        private DataTable carSeatTable;
        private int dataIndex;
        private double pageNumber;
        private int currentPage = 1;

        List<int> cardIds = new List<int>();

        private string searchQuery;
        public CarSeatManagement()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                cardIds.Add(i);
            }
            Get_CarSeat();
            Fill_Data();
        }

        private void Get_CarSeat()
        {
            carSeatTable = carseatTableAdapter.GetDataWithFilter($"%{searchQuery}%");
            pageNumber = Math.Ceiling(Convert.ToDouble(carSeatTable.Rows.Count) / 3);
        }

        private void Fill_Data()
        {
            dataCard1.Visible = false;
            dataCard2.Visible = false;
            dataCard3.Visible = false;

            int dataCardNumber = 1;

            if (carSeatTable.Rows.Count > 0)
            {
                for (int i = dataIndex; i < dataIndex + 3; i++)
                {
                    var dataCard = Controls.Find("dataCard" + dataCardNumber, true).FirstOrDefault() as Panel;
                    var nameLabel = Controls.Find("carSeatNameLabel" + dataCardNumber, true).FirstOrDefault() as Label;

                    if (i < carSeatTable.Rows.Count)
                    {
                        dataCard.Visible = true;
                        nameLabel.Text = $"{carSeatTable.Rows[i]["name"]}";
                        cardIds[dataCardNumber] = Convert.ToInt32(carSeatTable.Rows[i]["car_seat_id"]);

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
            CarSeatAdd carSeatAdd = new CarSeatAdd();
            carSeatAdd.ShowDialog();
            Get_CarSeat();
            Fill_Data();
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            CarSeatEdit carSeatEdit = new CarSeatEdit(cardIds[1]);
            carSeatEdit.ShowDialog();
            Get_CarSeat();
            Fill_Data();
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            CarSeatEdit carSeatEdit = new CarSeatEdit(cardIds[2]);
            carSeatEdit.ShowDialog();
            Get_CarSeat();
            Fill_Data();
        }

        private void editButton3_Click(object sender, EventArgs e)
        {
            CarSeatEdit carSeatEdit = new CarSeatEdit(cardIds[3]);
            carSeatEdit.ShowDialog();
            Get_CarSeat();
            Fill_Data();
        }

        private void trashButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                carseatTableAdapter.DeleteQuery(cardIds[1]);
                Get_CarSeat();
                Fill_Data();
            }
        }

        private void trashButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                carseatTableAdapter.DeleteQuery(cardIds[2]);
                Get_CarSeat();
                Fill_Data();
            }
        }

        private void trashButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                carseatTableAdapter.DeleteQuery(cardIds[3]);
                Get_CarSeat();
                Fill_Data();
            }
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchQuery = searchBar.Text;
                pageNumber = 1;
                dataIndex = 0;
                Get_CarSeat();
                Fill_Data();
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            searchQuery = "";
            searchBar.Text = string.Empty;
            dataIndex = 0;
            pageNumber = 1;
            Get_CarSeat();
            Fill_Data();
        }
    }
}
