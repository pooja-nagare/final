using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int OrderDetailId { get; set; }
        public int ProdId { get; set; }

       
    }
}

