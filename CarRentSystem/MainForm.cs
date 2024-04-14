using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentSystem.Dashboard;

namespace CarRentSystem
{
    public partial class MainForm : Form
    {
        public int loginId;
        public MainForm()
        {
            InitializeComponent();
        }

        public void Login_User(int userId, int level)
        {
            mainPanel.Controls.Clear();
            if (level == 1)
            {
                loginId = userId;
                DashboardAdmin dashboardAdmin = new DashboardAdmin(loginId)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                    FormBorderStyle = FormBorderStyle.None
                };
                mainPanel.Controls.Add(dashboardAdmin);
                dashboardAdmin.Show();
            }
            else
            {
                loginId = userId;
                DashboardKaryawan dashboardKaryawan = new DashboardKaryawan(loginId)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                    FormBorderStyle = FormBorderStyle.None
                };
                mainPanel.Controls.Add(dashboardKaryawan);
                dashboardKaryawan.Show();
            }
        }

        public void Login_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Login.Login login = new Login.Login
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            }; 
            mainPanel.Controls.Add(login);
            login.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login_Load(sender, e);
        }
    }
}
