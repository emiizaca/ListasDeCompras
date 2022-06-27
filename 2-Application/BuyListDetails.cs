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
    public class BuyListDetails
    {
        private BuyListRepository buyListRepository;
        private ProductRepository productRepository;

        public BuyListDetails(BuyListRepository buyListRepository, ProductRepository productRepository)
        {
            this.buyListRepository = buyListRepository;
            this.productRepository = productRepository;
        }

        public BuyListDetailsDTO Execute(Guid buyListId)
        {
            BuyList buyList = this.buyListRepository.getById(buyListId);


            foreach (var item in this.productRepository.GetByBuyListId(buyListId))
            {
                buyList.AddProduct(item);
            }

            List<ProductDTO> productsDTO = new List<ProductDTO>();
            foreach (Product actualProduct in buyList.Products())
            {
                productsDTO.Add(
                    new ProductDTO(
                        actualProduct.Name(),
                        actualProduct.Brand(),
                        actualProduct.Quantity(),
                        actualProduct.Category()
                        )
                    );
            }
             
            return new BuyListDetailsDTO(buyList.Id(), buyList.Name(), buyList.Classification(), buyList.BuyDate(), productsDTO);
        }
    }
}
