using System;
using System.Collections.Generic;

namespace ListasDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BuyList> buyList = new List<BuyList>();

            BuyList bl = new BuyList(
                "Compra de mañana",
                "car",
                DateTime.Parse("2022-5-23")
            );

            buyList.Add(bl);

            foreach (BuyList item in buyList)
            {
                Console.WriteLine(item.DataList());
            }

            List<Product> products = new List<Product>();

            Product p = new Product(
                "Yerba",
                "Cachamate",
                2,
                "almacen"
                );
            products.Add(p);

            foreach (var item in products)
            {
                Console.WriteLine(item.getProduct());
            }
        }
    }
}
