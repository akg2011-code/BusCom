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
    public partial class Info : MetroFramework.Forms.MetroForm
    {
        LoginUser loggedUser;
        public Info(LoginUser _loggedUser)
        {
            InitializeComponent();
            loggedUser = _loggedUser;
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard(loggedUser);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
