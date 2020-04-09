using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst.Models
{
    public class Trip
    {
        [Required]
        [Index("IX_UniqueTripForBus", 1, IsUnique = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Source")]
        public int SourceId { get; set; }
        
        [Required]
        [ForeignKey("Destination")]
        public int DestinationId { get; set; }

        [Index("IX_UniqueTripForBus", 2, IsUnique = true)]
        public DateTime DepartureTime { get; set; }
        
        [ForeignKey("Bus")]
        public int BusId { get; set; }
        public Bus Bus { get; set; }
        public Branch Source { get; set; }
        public Branch Destination { get; set; }
    }
}
