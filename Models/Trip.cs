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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Index("IX_UniqueTripPerTime", 1, IsUnique = true)]
        [Required]
        [ForeignKey("Source")]
        public int SourceId { get; set; }
        
        [Index("IX_UniqueTripPerTime", 2, IsUnique = true)]
        [Required]
        [ForeignKey("Destination")]
        public int DestinationId { get; set; }

        [Index("IX_UniqueTripPerTime", 3, IsUnique = true)]
        public DateTime DepartureTime { get; set; }
        
        [Index("IX_UniqueBus", IsUnique = true)]
        [ForeignKey("Bus")]
        public int BusId { get; set; }
        public Bus Bus { get; set; }
        public Branch Source { get; set; }
        public Branch Destination { get; set; }
    }
}
