using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Product
    {
        [Key]
       public int ProdId { get; set; }

       [Column(TypeName = "varchar(100)")]
        public string ProdName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProdDescription { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProdCategory { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string ProdImage { get; set; }

        [Column(TypeName = "decimal")]
        public decimal ProdPrice { get; set; }

        [Column(TypeName = "int")]
        public int Stock { get; set; }
    }
}
