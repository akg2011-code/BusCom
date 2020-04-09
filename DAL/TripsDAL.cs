using DatabaseCodeFirst.contextDB;
using DatabaseCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst.DAL
{
    public class TripsDAL
    {
        DatabaseContext ctx = new DatabaseContext();

        public ICollection<Trip> GetAvailableTrips()
        {
            List<Trip> availableTrips = new List<Trip>();
            foreach (var trip in ctx.Trips.Include("Source").Include("Destination").Include("Bus"))
            {
                if (new BusesDAL().GetAvailableSeats(trip.BusId).Count > 0 )
                {
                    availableTrips.Add(trip);
                }
            }
            return availableTrips;
        }

    }
}
