using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Seat")]
        [Index("IX_UniqueTicket", 1, IsUnique = true)]
        public int SeatId { get; set; }

        [Index("IX_UniqueTicket", 2, IsUnique = true)]

        [ForeignKey("Trip")]
        public int TripId { get; set; }

        public int TicketNumber { get; set; }

        public Trip Trip { get; set; }
        public Seat Seat { get; set; }
        public Customer Customer { get; set; }
    }
}
