using CarRentSystem.CarRentSystemDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentSystem.Management.Pelanggan
{
    public partial class PelangganAdd : Form
    {
        List<IdentityId> identityIds = new List<IdentityId>();

        public PelangganAdd()
        {
            InitializeComponent();
        }

        public class IdentityId
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public IdentityId(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        private void PelangganAdd_Load(object sender, EventArgs e)
        {
            DataTable identityTable = identity_typeTableAdapter.GetData();
            foreach (DataRow row in identityTable.Rows)
            {
                int id = Convert.ToInt32(row["identity_type_id"]);
                string name = row["Name"].ToString();
                identityIds.Add(new IdentityId(id, name));
            }
            comboBox1.DataSource = identityIds;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = namaTextBox.Text;
            string identityNumber = identityNumberTextBox.Text;
            int identityNumberId = Convert.ToInt32(comboBox1.SelectedValue);
            string address = addressTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            int gender = lakiRadio.Checked ? 1 : 0;

            if (name == "" || identityNumber == "" || address == "" || phoneNumber == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan!", MessageBoxButtons.OK);
            }
            else
            {
                int result = customersTableAdapter.InsertQuery(name, identityNumber, identityNumberId, address, gender, phoneNumber);
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
    }
}
