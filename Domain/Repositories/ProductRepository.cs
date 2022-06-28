using ListasDeCompras.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.Repositories
{
    public interface ProductRepository
    {
        public void Add(Product product);
        public List<Product> GetAll();
        public Product GetById(Guid id);
        public List<Product> GetByBuyListId(Guid buyListId);
        public void Update(Product product, Guid id);
        public void Delete(Guid id, Guid buyListId);
    }
}
