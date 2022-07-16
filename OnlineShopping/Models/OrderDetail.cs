using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class OrderDetail
    {
        [Key]
        public int OId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Fname { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Lname { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Landmark { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Pincode { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Mobile { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

    }
}
