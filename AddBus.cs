using DatabaseCodeFirst.contextDB;
using DatabaseCodeFirst.Models;
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
    public partial class AddBus : MetroFramework.Forms.MetroForm
    {
        DatabaseContext ctx = new DatabaseContext();
        LoginUser loggedUser;
        public AddBus(LoginUser _loggedUser)
        {
            InitializeComponent();
            loggedUser = _loggedUser;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bool exists = false;
            var Ids = ctx.Buses.Select(b => b.Id).ToArray();
            int newId = Ids.Max() + 1;

            foreach (var bus in ctx.Buses.ToList())
            {
                if (bus.BusTitle == txtBusTitle.Text)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                MessageBox.Show("This bus exists");
            }
            else
            {
                ctx.Buses.Add(new Bus() { Id = newId, BusTitle = txtBusTitle.Text });
                try
                {
                    ctx.SaveChanges();
                    var messagaeResult = MessageBox.Show("Added successfully", null, MessageBoxButtons.OK);
                    if (messagaeResult == DialogResult.OK)
                    {
                        Dashboard dashboard = new Dashboard(loggedUser);
                        this.Hide();
                        dashboard.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void AddBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard(loggedUser);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
