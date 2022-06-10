using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Infraestructure.Repositories
{
    public class ProductInMemoryRepository : ProductRepository
    {
        private List<Product> productList = new List<Product>();

        public void Add(Product product)
        {
            this.productList.Add(product);
        }

        public List<Product> GetAll()
        {
            return this.productList;
        }

        public Product GetById(Guid id)
        {
            return this.productList.Find(product => product.Id() == id);
        }
    }
}
