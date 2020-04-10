using testProj.Models;
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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        LoginUser loggedUser;
        public Register(LoginUser _loggedUser)
        {
            InitializeComponent();
            loggedUser = _loggedUser;
                
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard(loggedUser);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
