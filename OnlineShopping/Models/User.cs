using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string UserEmail { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal PhoneNumber { get; set; }
    }
}
