using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentSystem.Management.User;

namespace CarRentSystem.Manajemen.User
{
    public partial class UserManagement : Form
    {
        private DataTable usersTable = new DataTable();
        private int dataIndex;
        private double pageNumber;
        private int currentPage = 1;

        private List<int> cardIds = new List<int>();

        private string searchQuery;
        public UserManagement()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                cardIds.Add(i);
            }
            Get_User();
            Fill_Data();
        }

        private void Get_User()
        {
            usersTable = usersTableAdapter.GetDataWithFilter("%" + searchQuery + "%");
            pageNumber = Math.Ceiling(Convert.ToDouble(usersTable.Rows.Count) / 3);
        }

        private void Fill_Data()
        {
            dataCard1.Visible = false;
            dataCard2.Visible = false;
            dataCard3.Visible = false;

            int dataCardNumber = 1;

            if (usersTable.Rows.Count > 0)
            {
                for (int i = dataIndex; i < dataIndex + 3; i++)
                {
                    var dataCard = Controls.Find("dataCard" + dataCardNumber, true).FirstOrDefault() as Panel;
                    var usernameLabel = Controls.Find("usernameLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var nameLabel = Controls.Find("nameLabel" + dataCardNumber, true).FirstOrDefault() as Label;
                    var levelLabel = Controls.Find("levelLabel" + dataCardNumber, true).FirstOrDefault() as Label;

                    if (i < usersTable.Rows.Count)
                    {
                        dataCard.Visible = true;
                        usernameLabel.Text = usersTable.Rows[i]["username"].ToString();
                        nameLabel.Text = usersTable.Rows[i]["name"].ToString();
                        levelLabel.Text = usersTable.Rows[i]["level"].ToString() == "1" ? "Admin" : "Karyawan";

                        cardIds[dataCardNumber] = Convert.ToInt32(usersTable.Rows[i]["user_id"]);
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
            currentPage += 1;
            Fill_Data();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            dataIndex -= 3;
            currentPage -= 1;
            Fill_Data();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.ShowDialog();
            Get_User();
            Fill_Data();
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit(cardIds[1]);
            userEdit.ShowDialog();
            Get_User();
            Fill_Data();
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit(cardIds[2]);
            userEdit.ShowDialog();
            Get_User();
            Fill_Data();
        }

        private void editButton3_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit(cardIds[3]);
            userEdit.ShowDialog();
            Get_User();
            Fill_Data();
        }

        private void trashButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                usersTableAdapter.DeleteQuery(cardIds[1]);
                Get_User();
                Fill_Data();
            }
        }

        private void trashButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                usersTableAdapter.DeleteQuery(cardIds[2]);
                Get_User();
                Fill_Data();
            }
        }

        private void trashButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                usersTableAdapter.DeleteQuery(cardIds[3]);
                Get_User();
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
                Get_User();
                Fill_Data();
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            searchQuery = "";
            searchBar.Text = string.Empty;
            dataIndex = 0;
            currentPage = 1;
            Get_User();
            Fill_Data();
        }
    }
}
