using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst.Models
{
    public class Bus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string BusTitle { get; set; }
        public ICollection<Seat> Seats { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }
}
