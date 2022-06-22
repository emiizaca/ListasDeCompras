using ListasDeCompras.Application;
using ListasDeCompras.Application.DTO;
using ListasDeCompras.Domain.Repositories;
using ListasDeCompras.Infraestructure.Repositories;
using System;
using System.Collections.Generic;

namespace ListasDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyListRepository buyListRepository = new BuyListInMemoryRepository();
            ProductRepository productRepository = new ProductInMemoryRepository();

            BuyListCreator buyListCreatorService = new BuyListCreator(buyListRepository);
            ExistingLists existingListsService = new ExistingLists(buyListRepository);

            ProductCreator productCreadorService = new ProductCreator(productRepository);
            //ExistingProducts existingProducts = new ExistingProducts(productRepository);

            BuyListCreationDTO buyList = new BuyListCreationDTO(
                "Compra de mañana",
                "car",
                DateTime.Parse("2022-6-22")
            );
            buyListCreatorService.Execute(buyList);

            BuyListCreationDTO buyList2 = new BuyListCreationDTO(
                "Compra del finde",
                "general",
                DateTime.Parse("2022-6-23")
            );
            buyListCreatorService.Execute(buyList2);

            List<BuyListDTO> buyLists = existingListsService.Execute();
            foreach (BuyListDTO item in buyLists)
            {
                Console.WriteLine(item.DataList());
            }

            ProductCreationDTO product = new ProductCreationDTO(
                buyLists[0].Id(),
                "Yerba",
                "Marolio",
                3,
                "almacen"
                );
            productCreadorService.Execute(product);

            //foreach (ProductDTO item in existingProducts.Execute())
            //{
            //    Console.WriteLine(item.getProduct());
            //}
        }
    }
}
