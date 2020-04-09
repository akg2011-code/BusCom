using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst.Models
{
    public class Branch
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        [Required]
        public string BranchName { get; set; }
        
        [InverseProperty("Source")]
        public ICollection<Trip> TripsFrom { get; set; }
        
        [InverseProperty("Destination")]
        public ICollection<Trip> TripsTo { get; set; }
    }
}