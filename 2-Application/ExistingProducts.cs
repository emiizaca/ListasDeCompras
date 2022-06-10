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
    public class ExistingProducts
    {
        private ProductRepository repository;

        public ExistingProducts(ProductRepository repository)
        {
            this.repository = repository;
        }

        public List<ProductDTO> Execute()
        {
            List<ProductDTO> productDTO = new List<ProductDTO>();
            foreach (Product actualProduct in this.repository.GetAll())
            {
                productDTO.Add(
                    new ProductDTO(
                        actualProduct.Name(),
                        actualProduct.Brand(),
                        actualProduct.Quantity(),
                        actualProduct.Category()
                        )
                    );
            }
            return productDTO;
        }
    }
}
