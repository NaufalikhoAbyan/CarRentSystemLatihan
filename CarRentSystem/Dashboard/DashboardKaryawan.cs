using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentSystem.Management.Pelanggan;
using CarRentSystem.Management.RiwayatTransaksi;
using CarRentSystem.Settings;

namespace CarRentSystem.Dashboard
{
    public partial class DashboardKaryawan : Form
    {
        private int userId;
        public DashboardKaryawan(int userId)
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
            DashboardKaryawanData dashboardKaryawanData = new DashboardKaryawanData()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(dashboardKaryawanData);
            dashboardKaryawanData.Show();
        }

        private void DashboardKaryawan_Load(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }

        private void manajemenPelangganLabel_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            PelangganManagement pelangganManagement = new PelangganManagement()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(pelangganManagement);
            pelangganManagement.Show();
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword(userId);
            resetPassword.ShowDialog();
        }

        private void manajemenRiwayatTransasksiLabel_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            RiwayatTransaksiManagement riwayatTransaksiManagement = new RiwayatTransaksiManagement
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(riwayatTransaksiManagement);
            riwayatTransaksiManagement.Show();
        }

        //private void manajemenRiwayatTransasksiLabel_Click(object sender, EventArgs e)
        //{
        //    contentPanel.Controls.Clear();
        //    RiwayatTransaksiManagement riwayatTransaksiManagement = new RiwayatTransaksiManagement()
        //    {
        //        Dock = DockStyle.Fill,
        //        TopLevel = false,
        //        TopMost = true,
        //        FormBorderStyle = FormBorderStyle.None
        //    };
        //    contentPanel.Controls.Add(riwayatTransaksiManagement);
        //    riwayatTransaksiManagement.Show();
        //}
    }
}
