using ListasDeCompras.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Infraestructure.Repositories
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options ) : base(options)
        {

        }
        public DbSet<BuyList> BuyLists { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
