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
    public partial class AddBranch : MetroFramework.Forms.MetroForm
    {
        DatabaseContext ctx = new DatabaseContext();
        LoginUser loggedUser;
        public AddBranch(LoginUser _loggedUser)
        {
            InitializeComponent();
            loggedUser = _loggedUser;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bool exists = false;
            var Ids = ctx.Branches.Select(b => b.Id).ToArray();
            int newId = Ids.Max() + 1;

            foreach (var branch in ctx.Branches.ToList())
            {
                if (branch.BranchName == txtBranchName.Text)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                MessageBox.Show("This branch exists");
            }
            else
            {
                ctx.Branches.Add(new Branch() { Id = newId, BranchName = txtBranchName.Text });
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

        private void AddBranch_Load(object sender, EventArgs e)
        {
            
        }

        private void AddBranch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard(loggedUser);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
