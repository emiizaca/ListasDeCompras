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
            BuyListRepository repository = new BuyListInMemoryRepository();
            BuyListCreator buyListCreatorService = new BuyListCreator(repository);
            ExistingLists existingListsService = new ExistingLists(repository);

            BuyListDTO buyList = new BuyListDTO(
                "Compra de mañana",
                "car",
                DateTime.Parse("2022-6-10")
            );
            buyListCreatorService.Execute(buyList);

            BuyListDTO buyList2 = new BuyListDTO(
                "Compra del finde",
                "general",
                DateTime.Parse("2022-6-11")
            );
            buyListCreatorService.Execute(buyList2);

            foreach (BuyListDTO item in existingListsService.Execute())
            {
                Console.WriteLine(item.DataList());
            }
        }
    }
}
