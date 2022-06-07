using ListasDeCompras.Application;
using ListasDeCompras.Domain.Entities;
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

            BuyList buyList = BuyList.CreateNewBuyList(
                "Compra de mañana",
                "car",
                DateTime.Parse("2022-6-10")
            );
            buyListCreatorService.Execute(buyList);

            BuyList buyList2 = BuyList.CreateNewBuyList(
                "Compra del finde",
                "general",
                DateTime.Parse("2022-6-11")
            );
            buyListCreatorService.Execute(buyList2);

            foreach (BuyList item in existingListsService.Execute())
            {
                Console.WriteLine(item.DataList());
            }
        }
    }
}
