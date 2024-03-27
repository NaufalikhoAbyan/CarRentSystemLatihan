using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarRentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Login_Load(object sender, EventArgs e)
        {
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
