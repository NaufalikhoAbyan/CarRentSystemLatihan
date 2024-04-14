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
    public partial class PelangganEdit : Form
    {
        private int customerId;
        private string name;
        private string identityNumber;
        private int identityNumberId;
        private string address;
        private string phoneNumber;
        private int gender;
        private DataRow customerData;
        List<IdentityIds> identityTypeIds = new List<IdentityIds>();
        public PelangganEdit(int id)
        {
            InitializeComponent();
            customerId = id;
        }

        public class IdentityIds
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public IdentityIds(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        private void PelangganEdit_Load(object sender, EventArgs e)
        {
            customerData = customersTableAdapter.GetDataById(customerId).Rows[0];

            name = customerData["name"].ToString();
            namaTextBox.Text = name;

            identityNumber = customerData["identity_number"].ToString();
            identityNumberTextBox.Text = identityNumber;

            identityNumberId = Convert.ToInt32(customerData["identity_type_id"]);

            address = customerData["address"].ToString();
            addressTextBox.Text = address;

            phoneNumber = customerData["phone_number"].ToString();
            phoneNumberTextBox.Text = phoneNumber;

            gender = Convert.ToInt32(customerData["gender"]);
            if (gender == 1)
            {
                lakiRadio.Checked = true;
            }
            else
            {
                perempuanRadio.Checked = true;
            }

            DataTable IdentityIds = identity_typeTableAdapter.GetData();
            foreach (DataRow row in IdentityIds.Rows)
            {
                int id = Convert.ToInt32(row["identity_type_id"]);
                string name = row["name"].ToString();
                identityTypeIds.Add(new IdentityIds(id, name));
            }
            comboBox1.DataSource = identityTypeIds;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = identityNumberId;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            name = namaTextBox.Text;
            identityNumber = identityNumberTextBox.Text;
            identityNumberId = Convert.ToInt32(comboBox1.SelectedValue);
            address = addressTextBox.Text;
            phoneNumber = phoneNumberTextBox.Text;
            gender = lakiRadio.Checked == true ? 1 : 0;

            if (name == "" || identityNumber == "" || address == "" || phoneNumber == "")
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan!", MessageBoxButtons.OK);
            }
            else
            {
                int result = customersTableAdapter.UpdateQuery(name, identityNumber, identityNumberId, address, gender, phoneNumber, customerId);
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
    }
}
