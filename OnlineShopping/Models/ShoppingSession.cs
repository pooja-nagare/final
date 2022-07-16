using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class ShoppingSession
    {
        [Key]
        public int SSId { get; set; }
        public int UserId { get; set; }
        public int ShoppingSessionTotal { get; set; }
    }
}
