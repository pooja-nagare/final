using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class CartItem
    {
    
        [Key]
        public int CTId { get; set; }

        public int SSId { get; set; }

        public int ProdId { get; set; }

        public int Quantity { get; set; }
    }
}
