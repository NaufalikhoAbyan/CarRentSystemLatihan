using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentSystem.Management.CarSeat;
using CarRentSystem.Management.Mobil;
using CarRentSystem.Management.Tipe_Identitas;
using CarRentSystem.Manajemen.User;
using CarRentSystem.Settings;

namespace CarRentSystem.Dashboard
{
    public partial class DashboardAdmin : Form
    {
        private int userId;
        public DashboardAdmin(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda akan melakukan logout", "Peringatan!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            DashboardAdminData dasboardAdminData = new DashboardAdminData
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(dasboardAdminData);
            dasboardAdminData.Show();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }

        private void manajemenUserLabel_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            UserManagement userManagement = new UserManagement
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(userManagement);
            userManagement.Show();
        }

        private void manajemenMobilLabel_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            MobilManagement mobilManagement = new MobilManagement
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(mobilManagement);
            mobilManagement.Show();
        }

        private void managemenCarSeatLabel_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            CarSeatManagement carSeatManagement = new CarSeatManagement()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(carSeatManagement);
            carSeatManagement.Show();
        }

        private void tipeIdentitasManagemen_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            TipeIdentitasManagement tipeIdentitasManagement = new TipeIdentitasManagement()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(tipeIdentitasManagement);
            tipeIdentitasManagement.Show();
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword(userId);
            resetPassword.ShowDialog();
        }
    }
}
