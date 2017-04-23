using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qbags.Models;
using Microsoft.EntityFrameworkCore;

namespace Qbags.Data
{
    public class BagContext : DbContext
    {
        public BagContext(DbContextOptions<BagContext> options) : base(options)
        {
        }

        public DbSet<Bag> Bags { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Cartbag> Cartbag { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderbag> Orderbags { get; set; }
        public DbSet<User> Users { get; set; }

    }
}