using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryCodeAPI.Model
{
    public class CustomContext: DbContext 
    {
        public DbSet<cart> carts { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<User> users { get; set; }

        public DbSet<Order> orders { get; set; }

        public DbSet<OrderDetails> orderDetails { get; set; }

        public CustomContext(DbContextOptions option) : base(option)
        {

        }
    }
}
