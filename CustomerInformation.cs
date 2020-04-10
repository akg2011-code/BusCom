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
    public partial class CustomerInformation : MetroFramework.Forms.MetroForm
    {
        LoginUser loggedUser;
        public CustomerInformation(LoginUser _loggedUser)
        {
            InitializeComponent();
            loggedUser = _loggedUser;
        }

        private void CustomerInformation_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Reservation reservForm = new Reservation(loggedUser,txtName.Text);
            this.Hide();
            reservForm.ShowDialog();

            this.Close();
        }
    }
}
