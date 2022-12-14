using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace NPPP.Data
{
    public class NPPPDbContext : DbContext
    {
        public NPPPDbContext(DbContextOptions<NPPPDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer>? Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
