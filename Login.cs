using DatabaseCodeFirst.contextDB;
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
        LoginUser loggedUser;
        Dashboard dashboard ;
        DatabaseContext ctx = new DatabaseContext();
        public Login()
        {
            
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string userName = userTextbox.Text;
            string password = passwordTextBox.Text;
            loggedUser = ctx.Users.Where(u => u.userName == userName && u.Password == password).FirstOrDefault();

            if (loggedUser != null)
            {
                dashboard = new Dashboard(loggedUser);
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("user name or password is invalid !");

                //}
                //else if (userTextbox.Text == User.userName && passwordTextBox.Text == User.userPassword)
                //{
                //    dashboard = new Dashboard(User.userName, User.userPassword);
                //    this.Hide();
                //    dashboard.ShowDialog();
                //    this.Close();

                //}

                //if (userTextbox.Text != User.userName || passwordTextBox.Text != User.Password || userTextbox.Text == User.userName && passwordTextBox.Text == User.Password)
                //{
                //    MessageBox.Show("user name or password is invalid !");
                //}


        }
    }   
}
