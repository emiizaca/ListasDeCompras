﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Application.DTO
{
    public class ProductDTO
    {
        private Guid buyListId;
        private string name;
        private string brand;
        private int quantity;
        private string category;

        public ProductDTO(Guid id, string name, string brand, int quantity, string category)
        {
            this.buyListId = id;
            this.name = name;
            this.brand = brand;
            this.quantity = quantity;
            this.category = category;
        }

        public Guid BuyListId()
        {
            return this.buyListId;
        }
        public string Name()
        {
            return this.name;
        }

        public string Brand()
        {
            return this.brand;
        }

        public int Quantity()
        {
            return this.quantity;
        }

        public string Category()
        {
            return this.category;
        }
        public string getProduct()
        {
            return $"Product name: {this.Name()}\nBrand: {this.Brand()}\nQuantity: {this.Quantity()}\nThe category is: {this.Category()}";
        }
    }
}
