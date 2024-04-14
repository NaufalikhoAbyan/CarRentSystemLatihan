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
    public partial class TipeIdentitasManagement : Form
    {
        private DataTable tipeIdentitasTable;
        private int dataIndex;
        private double pageNumber;
        private int currentPage = 1;
        private string searchQuery;

        List<int> cardIds = new List<int>();
        public TipeIdentitasManagement()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                cardIds.Add(i);
            }
            Get_Identity();
            Fill_Data();
        }

        private void Get_Identity()
        {
            tipeIdentitasTable = identity_typeTableAdapter.GetDataWithFilter($"%{searchQuery}%");
            pageNumber = Math.Ceiling(Convert.ToDouble(tipeIdentitasTable.Rows.Count) / 3);
        }

        private void Fill_Data()
        {
            dataCard1.Visible = false;
            dataCard2.Visible = false;
            dataCard3.Visible = false;

            int dataCardNumber = 1;
            if (tipeIdentitasTable.Rows.Count > 0)
            {
                for (int i = dataIndex; i < dataIndex + 3; i++)
                {
                    var dataCard = Controls.Find("dataCard" + dataCardNumber, true).FirstOrDefault() as Panel;
                    var nameLabel = Controls.Find("identityTypeNameLabel" + dataCardNumber, true).FirstOrDefault() as Label;

                    if (i < tipeIdentitasTable.Rows.Count)
                    {
                        dataCard.Visible = true;
                        nameLabel.Text = $"{tipeIdentitasTable.Rows[i]["name"]}";
                        cardIds[dataCardNumber] = Convert.ToInt32(tipeIdentitasTable.Rows[i]["identity_type_id"]);

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
            TipeIdentitasAdd tipeIdentitasAdd = new TipeIdentitasAdd();
            tipeIdentitasAdd.ShowDialog();
            Get_Identity();
            Fill_Data();
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            TipeIdentitasEdit tipeIdentitasEdit = new TipeIdentitasEdit(cardIds[1]);
            tipeIdentitasEdit.ShowDialog();
            Get_Identity();
            Fill_Data();
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            TipeIdentitasEdit tipeIdentitasEdit = new TipeIdentitasEdit(cardIds[2]);
            tipeIdentitasEdit.ShowDialog();
            Get_Identity();
            Fill_Data();
        }

        private void editButton3_Click(object sender, EventArgs e)
        {
            TipeIdentitasEdit tipeIdentitasEdit = new TipeIdentitasEdit(cardIds[3]);
            tipeIdentitasEdit.ShowDialog();
            Get_Identity();
            Fill_Data();
        }

        private void trashButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                identity_typeTableAdapter.DeleteQuery(cardIds[1]);
                Get_Identity();
                Fill_Data();
            }
        }

        private void trashButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                identity_typeTableAdapter.DeleteQuery(cardIds[2]);
                Get_Identity();
                Fill_Data();
            }
        }

        private void trashButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Peringatan!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                identity_typeTableAdapter.DeleteQuery(cardIds[3]);
                Get_Identity();
                Fill_Data();
            }
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchQuery = searchBar.Text;
                Get_Identity();
                Fill_Data();
                dataIndex = 0;
                currentPage = 1;
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            searchQuery = "";
            searchBar.Text = String.Empty;
            Get_Identity();
            Fill_Data();
            dataIndex = 0;
            currentPage = 1;
        }
    }
}
