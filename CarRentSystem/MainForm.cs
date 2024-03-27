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
        public MainForm()
        {
            InitializeComponent();
        }

        public void Login_User(int userId, int level)
        {
            mainPanel.Controls.Clear();
            if (userId == 1)
            {
                DashboardAdmin dashboardAdmin = new DashboardAdmin
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                    FormBorderStyle = FormBorderStyle.None
                };
                mainPanel.Controls.Add(dashboardAdmin);
                dashboardAdmin.Show();
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
