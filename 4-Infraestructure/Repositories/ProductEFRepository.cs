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
    public class ProductEFRepository : ProductRepository //todo - falta implementar el metodo getByBuyListID
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
            throw new NotImplementedException();
        }

        public Product GetById(Guid id)
        {
            using var context = new DatabaseContext();
            List<Product> products = context.products.ToList();
            return products.Find(product => product.Id() == id);
        }
    }
}
