using ListasDeCompras.Application.DTO;
using ListasDeCompras.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Application
{
    public class ProductRemover
    {
        private ProductRepository repository;

        public ProductRemover(ProductRepository repository)
        {
            this.repository = repository;
        }
        public void Execute(Guid id, Guid buyListId)
        {
            this.repository.Delete(id, buyListId);
        }
    }
}
