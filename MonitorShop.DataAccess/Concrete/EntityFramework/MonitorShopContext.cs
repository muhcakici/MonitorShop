using Microsoft.EntityFrameworkCore;
using MonitorShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorShop.DataAccess.Concrete.EntityFramework
{
    public class MonitorShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MonitorShopDB;Integrated Security=True");
        }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
