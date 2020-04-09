using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [StringLength(11)]
        [RegularExpression("^01[0|1|2|5][0-9]{8}$", ErrorMessage = "Enter a valid mobile number")]
        public string MobileNumber { get; set; }

        [RegularExpression(@"^([a-z|A-Z|0-9]+)\@[a-z|A-Z]{3,}\.([a-z|A-Z]){3,}\.*([a-z|A-Z])*$", ErrorMessage = "Enter a valid Email")]
        public string Email { get; set; }
    }
}
