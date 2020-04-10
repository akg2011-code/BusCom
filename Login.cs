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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        LoginUser User;
        Dashboard dashboard ;
        public Login()
        {
            
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            User = new LoginUser();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LoginUser User = new LoginUser();
            User.adminName = "admin";
            User.adminPassword = "admin";
            User.userName = "client";
            User.userPassword = "client";

            if (userTextbox.Text == User.adminName && passwordTextBox.Text == User.adminPassword)
            {
                dashboard = new Dashboard(User.adminName, User.adminPassword);
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else if (userTextbox.Text == User.userName && passwordTextBox.Text == User.userPassword)
            {
                dashboard = new Dashboard(User.userName, User.userPassword);
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
                
            }

            if (userTextbox.Text != User.adminName || passwordTextBox.Text != User.adminPassword || userTextbox.Text == User.userName && passwordTextBox.Text == User.userPassword)
            {
                MessageBox.Show("user name or password is invalid !");
            }


        }
    }   
}
