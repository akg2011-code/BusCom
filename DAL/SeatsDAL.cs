using DatabaseCodeFirst.contextDB;
using DatabaseCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst.DAL
{
    public class SeatsDAL
    {
        DatabaseContext ctx = new DatabaseContext();

        public void Reserve(int[] seats) 
        {
            var seatsReserved = ctx.Seats.Where(s => seats.Contains(s.SeatNumber));
            foreach (var seat in seatsReserved)
            {
                seat.IsAvailable = false;
            }
            ctx.SaveChanges();
        }

        public List<Seat> GetAllSeats() 
        {
            return ctx.Seats.ToList();
        }
    }
}
