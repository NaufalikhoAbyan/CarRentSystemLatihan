using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentSystem.Management.Pelanggan
{
    public partial class PelangganManagement : Form
    {
        private DataTable customerTable;
        private int dataIndex;
        private double pageNumber;
        private int currentPage = 1;
        private string searchQuery;
        List<int> cardIds = new List<int>();
        public PelangganManagement()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                cardIds.Add(i);
            }
            Get_Customer();
            Fill_Data();
        }

        private void Get_Customer()
        {
            customerTable = customersTableAdapter.GetDataWithFilter($"%{searchQuery}%");
            pageNumber = Math.Ceiling(Convert.ToDouble(customerTable.Rows.Count) / 3);
        }

        private void Fill_Data()
        {
            dataCard1.Visible = false;
            dataCard2.Visible = false;
            dataCard3.Visible = false;

            int dataCardNumber = 1;
            if (customerTable.Rows.Count > 0)
            {
                for (int i = dataIndex; i < dataIndex + 3; i++)
                {
                    var dataCard = Controls.Find("dataCard" + dataCardNumber, true).FirstOrDefault() as Panel;
                    var nameLabel = Controls.Find("nameLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var addressLabel = Controls.Find("addressLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var genderLabel = Controls.Find("genderLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var phoneNumberLabel = Controls.Find("phoneNumberLabel" + dataCardNumber, true).FirstOrDefault() as Label;

                    if (i < customerTable.Rows.Count)
                    {
                        dataCard.Visible = true;
                        nameLabel.Text = customerTable.Rows[i]["name"].ToString();
                        addressLabel.Text = customerTable.Rows[i]["address"].ToString();
                        genderLabel.Text = customerTable.Rows[i]["gender"].ToString() == "1" ? "Laki-Laki" : "Perempuan";
                        phoneNumberLabel.Text = customerTable.Rows[i]["phone_number"].ToString();

                        cardIds[dataCardNumber] = Convert.ToInt32(customerTable.Rows[i]["customer_id"]);

                        dataCardNumber++;
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
            PelangganAdd pelangganAdd = new PelangganAdd();
            pelangganAdd.ShowDialog();
            Get_Customer();
            Fill_Data();
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            PelangganEdit pelangganEdit = new PelangganEdit(cardIds[1]);
            pelangganEdit.ShowDialog();
            Get_Customer();
            Fill_Data();
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            PelangganEdit pelangganEdit = new PelangganEdit(cardIds[2]);
            pelangganEdit.ShowDialog();
            Get_Customer();
            Fill_Data();
        }

        private void editButton3_Click(object sender, EventArgs e)
        {
            PelangganEdit pelangganEdit = new PelangganEdit(cardIds[3]);
            pelangganEdit.ShowDialog();
            Get_Customer();
            Fill_Data();
        }

        private void trashButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                customersTableAdapter.DeleteQuery(cardIds[1]);
                Get_Customer();
                Fill_Data();
            }
        }

        private void trashButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                customersTableAdapter.DeleteQuery(cardIds[2]);
                Get_Customer();
                Fill_Data();
            }
        }

        private void trashButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                customersTableAdapter.DeleteQuery(cardIds[3]);
                Get_Customer();
                Fill_Data();
            }
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchQuery = searchBar.Text;
                currentPage = 1;
                dataIndex = 0;
                Get_Customer();
                Fill_Data();
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            searchQuery = "";
            searchBar.Text = string.Empty;
            currentPage = 1;
            dataIndex = 0;
            Get_Customer();
            Fill_Data();
        }
    }
}
