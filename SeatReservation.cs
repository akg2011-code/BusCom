using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCodeFirst.contextDB;
using DatabaseCodeFirst.Models;
using DatabaseCodeFirst.DAL;
using testProj.Models;

namespace testProj
{
    public partial class SeatReservation : MetroFramework.Forms.MetroForm
    {
        private List<int> seatsChosen;
        private SeatsDAL seatsDAL = new SeatsDAL();
        private BusesDAL busesDAL = new BusesDAL();
        private Trip trip;
        private LoginUser loggedUser;
        private string customerName;
        public SeatReservation(LoginUser _loggedUser,Trip _trip,string _customerName)
        {
            InitializeComponent();
            trip = _trip;
            loggedUser = _loggedUser;
            customerName = _customerName;
        }


        private void SeatReservation_Load(object sender, EventArgs e)
        {
            InitSeats(trip.BusId);
            seatsChosen = new List<int>();
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (btn.BackColor == Color.FromArgb(1, 113, 187))
            {
                if (seatsChosen.Count < 3)
                {
                    seatsChosen.Add(int.Parse(btn.Text));
                    btn.BackColor = Color.LightGreen;
                }
            }
            else
            {
                seatsChosen.Remove(int.Parse(btn.Text));
                btn.BackColor = Color.FromArgb(1,113,187);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            seatsDAL.Reserve(seatsChosen.ToArray(),trip.BusId);
            Ticket formTicket = new Ticket(loggedUser, trip,seatsChosen,customerName);
            this.Hide();
            formTicket.ShowDialog();
            this.Close();
        }

        private void InitSeats(int _busId) 
        {
            List<Seat> availableSeats = busesDAL.GetAvailableSeats(_busId);
            var buttons = Controls.OfType<Button>().Where(b=>b.Name != "btnNext");

            foreach (var btn in buttons)
            {
                btn.Enabled = false;
                btn.BackColor = Color.Red;
            }

            foreach (var seat in availableSeats)
            {
                buttons.FirstOrDefault(b => b.Text == seat.SeatNumber.ToString()).Enabled = true;
                buttons.FirstOrDefault(b => b.Text == seat.SeatNumber.ToString()).BackColor = Color.FromArgb(1, 113, 187);                
            }
        }

    }
}
