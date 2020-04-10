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
using testProj.Models;

namespace testProj
{
    public partial class Reservation : MetroFramework.Forms.MetroForm
    {
        TripsDAL tripsDAL = new TripsDAL();
        BranchDAL branchDAL = new BranchDAL();
        LoginUser loggedUser;
        string customerName;
        public Reservation(LoginUser _loggedUser,string _customerName)
        {
            InitializeComponent();
            loggedUser = _loggedUser;
            customerName = _customerName;
        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTo.Items.Clear();
            cbTo.Text = "";
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
            cbTo.SelectedItem = cbTo.Items[0];
            getTripsTime(new object(), new EventArgs());
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

        private void getTripsTime(object o , EventArgs e) 
        {
            if (cbFrom.SelectedItem != null && cbTo.SelectedItem != null)
            {
                cbTime.Items.Clear();
                cbTime.Text = "";

                Trip selectedTrip = getTripDetails();

                var trips = tripsDAL.GetAvailableTrips()
                            .Where(t => t.Source.Id == selectedTrip.Source.Id && t.Destination.Id == selectedTrip.Destination.Id && t.DepartureTime.Date == selectedTrip.DepartureTime.Date);
                if (trips.ToList().Count > 0)
                {
                    foreach (var trip in trips)
                    {
                        cbTime.Items.Add(trip.DepartureTime.TimeOfDay/*.ToString("hh':'mm")*/);
                    }
                    cbTime.SelectedItem = cbTime.Items[0];
                    
                }
                
            }
        }

        
        private void Reservation_Load(object sender, EventArgs e)
        {
            populateComboBox();
            cbFrom.SelectedItem = cbFrom.Items[0];
            cbFrom_SelectedIndexChanged(new object(),new EventArgs());
            cbTo.SelectedItem = cbTo.Items[0];
            metroDateTime1.MinDate = DateTime.Now;
        }

        private Trip getTripDetails() 
        {
            var source = branchDAL.GetBranchByName(cbFrom.SelectedItem.ToString());
            var destination = branchDAL.GetBranchByName(cbTo.SelectedItem.ToString());
            var date = metroDateTime1.Value.Date;
            return new Trip() { Source = source, Destination = destination,DepartureTime = date};
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var selectedTrip = getTripDetails();
            DateTime departureDate = metroDateTime1.Value.Date;
            TimeSpan departureTime = (TimeSpan)cbTime.SelectedItem;
            DateTime departureDateTime = new DateTime(departureDate.Year,departureDate.Month,departureDate.Day,departureTime.Hours,departureTime.Minutes,0);
            
            Trip trip = tripsDAL.GetAvailableTrips()
                            .Where(t => t.Source.Id == selectedTrip.Source.Id && t.Destination.Id == selectedTrip.Destination.Id && t.DepartureTime == departureDateTime).FirstOrDefault();

            if (trip != null)
            {
                SeatReservation seatForm = new SeatReservation(loggedUser,trip,customerName);
                this.Hide();
                seatForm.ShowDialog();
                this.Close();
            }
        }
    }
}
