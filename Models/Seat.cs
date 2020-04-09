using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCodeFirst.Models
{
    public class Seat
    {
        public Seat()
        {
            IsAvailable = true;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        [Index("IX_UniqueSeat", 2, IsUnique = true)]
        [Range(1,26)]
        public int SeatNumber { get; set; }
        public bool IsAvailable { get; set; }

        [ForeignKey("Bus")]
        [Index("IX_UniqueSeat",1,IsUnique =true)]
        public int BusId { get; set; }
        public Bus Bus { get; set; }
    }
}
