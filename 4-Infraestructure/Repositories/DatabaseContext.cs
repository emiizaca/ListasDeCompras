using ListasDeCompras.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace _4_Infraestructure.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DMKJBO3/SQLEXPRESS; Initial Catalog = ListasDeCompras; Integrated Security = True");
            }
        }
        public virtual DbSet<BuyList> buyLists { get; set; }
        public virtual DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuyList>().ToTable("BuyList");
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
