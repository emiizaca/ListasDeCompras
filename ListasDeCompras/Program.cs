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
            DependencyInjectionManager diManager = new DependencyInjectionManager();

            BuyListCreator buyListCreatorService = diManager.Resolve<BuyListCreator>();
            ExistingLists existingListsService = diManager.Resolve<ExistingLists>();
            ProductCreator productCreadorService = diManager.Resolve<ProductCreator>();
            ProductRemover productRemoverService = diManager.Resolve<ProductRemover>();
            BuyListDetails buyListDetails = diManager.Resolve<BuyListDetails>();

            //Console.WriteLine($"Lista con id: {buyLists[0].Id()}");
            //BuyListDetailsDTO buyList3 = buyListDetails.Execute(buyLists[0].Id());
            //Console.WriteLine(buyList3.DataList());
            //foreach (var item in buyList3.Products())
            //{
            //    Console.WriteLine(item.getProduct());
            //};

            Guid buyListId = new Guid("2238dd18-4786-47c6-a34f-2d37150e60b5");

            BuyListCreationDTO buyList = new BuyListCreationDTO(
                "Compra de comida",
                "general",
                DateTime.Parse("2022-6-28")
                );
            buyListCreatorService.Execute(buyList);

            ProductCreationDTO product = new ProductCreationDTO(
                buyListId,
                "Yerba",
                "Marolio",
                3,
                "almacen"
                );
            productCreadorService.Execute(product);

            //Guid productId = new Guid("c06d4691-d218-41b0-806c-9177aa567e9e");
            //productRemoverService.Execute(productId, buyListId);
        }
    }
}
