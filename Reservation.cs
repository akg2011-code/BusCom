using DatabaseCodeFirst.DAL;
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
using testProj.DAL;

namespace testProj
{
    public partial class Reservation : MetroFramework.Forms.MetroForm
    {
        TripsDAL tripsDAL = new TripsDAL();
        public Reservation()
        {
            InitializeComponent();
            populateComboBox();
        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTo.Items.Clear();
            BranchDAL branchDAL = new BranchDAL();
            Branch SelectedBranch = branchDAL.GetBranchByName(cbFrom.SelectedItem.ToString());
            List<Branch> destinations = new List<Branch>();
            foreach (var trip in tripsDAL.GetAvailableTrips().Where(t=>t.SourceId == SelectedBranch.Id))
            {
                destinations.Add(trip.Destination);
            }
            foreach (var item in destinations)
            {
                if (!cbTo.Items.Contains(item.BranchName))
                {
                    cbTo.Items.Add(item.BranchName);
                }
            }

        }

        private void populateComboBox() 
        {
            var availableTrips = tripsDAL.GetAvailableTrips();
            List<Branch> sources = new List<Branch>();
            foreach (var trip in availableTrips)
            {
                sources.Add(trip.Source);
            }

            foreach (var item in sources)
            {
                if (!cbFrom.Items.Contains(item.BranchName))
                {
                    cbFrom.Items.Add(item.BranchName);
                }
            }
        }

        
    }
}
