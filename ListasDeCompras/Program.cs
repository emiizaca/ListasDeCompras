using ListasDeCompras.Application;
using ListasDeCompras.Application.DTO;
using ListasDeCompras.Domain.Repositories;
using ListasDeCompras.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ListasDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<DataBaseContext>().UseInMemoryDatabase(databaseName: "ListasDeCompras").Options;

            BuyListRepository buyListRepository = new BuyListInMemoryRepository(options);
            ProductRepository productRepository = new ProductInMemoryRepository(options);

            BuyListCreator buyListCreatorService = new BuyListCreator(buyListRepository);
            ExistingLists existingListsService = new ExistingLists(buyListRepository);

            ProductCreator productCreador = new ProductCreator(productRepository);
            ExistingProducts existingProducts = new ExistingProducts(productRepository);

            BuyListDTO buyList = new BuyListDTO(
                "Compra de mañana",
                "car",
                DateTime.Parse("2022-06-15")
            );
            buyListCreatorService.Execute(buyList);

            BuyListDTO buyList2 = new BuyListDTO(
                "Compra del finde",
                "general",
                DateTime.Parse("2022-06-16")
            );
            buyListCreatorService.Execute(buyList2);

            foreach (BuyListDTO item in existingListsService.Execute())
            {
                Console.WriteLine(item.DataList());
            }

            ProductDTO product = new ProductDTO(
                "Yerba",
                "Marolio",
                3,
                "almacen"
                );
            productCreador.Execute(product);

            foreach (ProductDTO item in existingProducts.Execute())
            {
                Console.WriteLine(item.getProduct());
            }
        }
    }
}
