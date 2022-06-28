using _4_Infraestructure.Repositories;
using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Infraestructure.Repositories
{
    public class ProductEFRepository : ProductRepository
    {
        
        public void Add(Product product)
        {
            using var context = new DatabaseContext();
            context.products.Add(product);
            context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            using var context = new DatabaseContext();
            return context.products.ToList();
        }

        public List<Product> GetByBuyListId(Guid buyListId)
        {
            using var context = new DatabaseContext();
            List<Product> products = context.products.Where(x => x.BuyListId() == buyListId).ToList();
            return products;
        }

        public Product GetById(Guid id)
        {
            using var context = new DatabaseContext();
            List<Product> products = context.products.ToList();
            return products.Find(product => product.Id() == id);
        }
    }
}
