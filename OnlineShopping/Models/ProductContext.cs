using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        public DbSet<Order>Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<ShoppingSession> ShoppingSessions { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

    }
}
