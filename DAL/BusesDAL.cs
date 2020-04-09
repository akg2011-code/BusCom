using DatabaseCodeFirst.Models;
using DatabaseCodeFirst.contextDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DatabaseCodeFirst.DAL
{
    public class BusesDAL
    {

        DatabaseContext ctx = new DatabaseContext();
        public List<Seat> GetAvailableSeats(int busId)
        {
            List<Seat> availableSeats = new List<Seat>();
            Bus bus = ctx.Buses.Where(b => b.Id == busId).Include(b=>b.Seats).FirstOrDefault();
            foreach (var seat in bus.Seats)
            {
                if (seat.IsAvailable)
                    availableSeats.Add(seat);
            }
            return availableSeats;
        }
    }
}
