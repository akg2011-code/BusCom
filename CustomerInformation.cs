using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            lblValidName.Visible = false;
            lblValidEmail.Visible = false;
            lblValidPhone.Visible = false;

            if (PhoneChecked() && EmailChecked() && txtName.Text != "")
            {
                Reservation reservForm = new Reservation(loggedUser, txtName.Text);
                this.Hide();
                reservForm.ShowDialog();
                this.Close();
            }
            else if (txtName.Text == "")
            {
                lblValidName.Visible = true;
            }
             else if (!PhoneChecked())
            {
                lblValidPhone.Visible = true;
            }
            else if (!EmailChecked())
            {
                lblValidEmail.Visible = true;
            }


        }
        private bool PhoneChecked()
        {
            Regex regexPhone = new Regex("^01[0|1|2|5][0-9]{8}$");
            return regexPhone.IsMatch(txtPhone.Text);
        }
        private bool EmailChecked() 
        {
            Regex regexMail = new Regex(@"^([a-z|A-Z|0-9]+)\@[a-z|A-Z]{3,}\.([a-z|A-Z]){3,}\.*([a-z|A-Z])*$");
            return regexMail.IsMatch(txtEmail.Text);
        }

    }
}
