using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryCodeAPI.Model
{
    public class OrderDetailsDBContext:DbContext
    {
        public OrderDetailsDBContext(DbContextOptions<OrderDetailsDBContext> option):base(option)
        {

        }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
