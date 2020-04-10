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
            //if (loggedUser.userName == "client" && loggedUser.Password == "client")
            //{
            //    branchBtn.Enabled = false;
            //    TripBtn.Enabled = false;
            //    BusBtn.Enabled = false;
            //}

        }

        private void branchBtn_Click(object sender, EventArgs e)
        {

        }

        private void TripBtn_Click(object sender, EventArgs e)
        {

        }

        private void BusBtn_Click(object sender, EventArgs e)
        {

        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
