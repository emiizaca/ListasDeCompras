using ListasDeCompras.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ProductRepository
    {
        public void Add(Product product);
        public List<Product> GetAll();
        public Product GetById(Guid id);
    }
}
