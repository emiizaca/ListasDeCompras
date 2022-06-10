using ListasDeCompras.Application.DTO;
using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Application
{
    public class ProductCreator
    {
        private ProductRepository repository;

        public ProductCreator(ProductRepository repository)
        {
            this.repository = repository;
        }

        public void Execute(ProductDTO productDTO)
        {
            this.repository.Add(
                Product.CreateNewProduct(
                    productDTO.Name(),
                    productDTO.Brand(),
                    productDTO.Quantity(),
                    productDTO.Category()
                    )
                );
        }
    }
}
