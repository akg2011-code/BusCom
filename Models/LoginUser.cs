using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProj.Models
{
    public class LoginUser
    {
        [Key]
        public int Id { get; set; }
        [Index("IX_Unique_Username",IsUnique =true)]
        [MaxLength(450)]
        public string userName { get; set; }
        public string Password { get; set; }
    }
}
