using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Infraestructure.Repositories
{
    public class ProductInMemoryRepository : DataBaseContext, ProductRepository
    {
        public ProductInMemoryRepository(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public void Add(Product product)
        {
            this.Products.Add(product);
            this.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return this.Products.ToList<Product>();
        }

        public Product GetById(string id)
        {
            return this.Products.SingleOrDefault(p => p.Id() == id);
            //return this.productList.Find(product => product.Id() == id);
        }
    }
}
