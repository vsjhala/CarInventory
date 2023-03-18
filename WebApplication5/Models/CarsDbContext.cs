using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication5.Models
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext() : base("CarsConnectionString")
        {
        }

        public DbSet<Cars> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>().HasKey(x => x.Id);
        }
    }
}