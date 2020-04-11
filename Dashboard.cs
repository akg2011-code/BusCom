using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testProj.Models;

namespace testProj
{
    
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        LoginUser loggedUser;
        public Dashboard(LoginUser _loggedUser)
        {
            loggedUser = _loggedUser;
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CustomerInformation customerForm = new CustomerInformation(loggedUser);
            this.Hide();
            customerForm.ShowDialog();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (!loggedUser.isAdmin)
            {
                branchBtn.Enabled = false;
                TripBtn.Enabled = false;
                BusBtn.Enabled = false;
            }

        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            AddBranch branchForm = new AddBranch(loggedUser);
            this.Hide();
            branchForm.ShowDialog();
            this.Close();
        }

        private void TripBtn_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register(loggedUser);
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

        private void BusBtn_Click(object sender, EventArgs e)
        {
            AddBus busForm = new AddBus(loggedUser);
            this.Hide();
            busForm.ShowDialog();
            this.Close();
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            Info infoForm = new Info(loggedUser);
            this.Hide();
            infoForm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
