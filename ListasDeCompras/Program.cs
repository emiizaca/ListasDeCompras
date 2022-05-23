using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace ListasDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyListRepository repository = new BuyListInMemoryRepository();

            BuyList buyList = BuyList.CreateNewBuyList(
                "Compra de mañana",
                "car",
                DateTime.Parse("2022-5-24"),
                repository
            );
            buyList.Save();

            BuyList buyList2 = BuyList.CreateNewBuyList(
                "Compra del finde",
                "general",
                DateTime.Parse("2022-5-25"),
                repository
            );
            buyList2.Save();

            foreach (BuyList item in repository.GetAll())
            {
                Console.WriteLine(item.DataList());
            }
        }
    }
}
