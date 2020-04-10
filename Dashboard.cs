using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProj
{
    
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        string User;
        string Password;
        public Dashboard(string userName,string password)
        {
            User = userName;
            Password = password;
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (User == "client" && Password == "client")
            {
                branchBtn.Enabled = false;
                TripBtn.Enabled = false;
                BusBtn.Enabled = false;
            }

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
