using System;
using System.Collections.Generic;

namespace ListasDeCompras.Application.DTO
{
    public class BuyListDetailsDTO
    {
        private Guid id;
        private string name;
        private string classification;
        private DateTime buyDate;
        private List<ProductDTO> products;

        public BuyListDetailsDTO(Guid id, string name, string classification, DateTime buyDate, List<ProductDTO> products)
        {
            this.id = id;
            this.name = name;
            this.classification = classification;
            this.buyDate = buyDate;
            this.products = products;
        }

        public Guid Id()
        {
            return this.id;
        }
        public string Name()
        {
            return this.name;
        }
        public string Classification()
        {
            return this.classification;
        }
        public DateTime BuyDate()
        {
            return this.buyDate;
        }

        public List<ProductDTO> Products()
        {
            return this.products;
        }
        public string DataList()
        {
            return $"Id: {this.Id()}\nList name: {this.Name()}\nThe classification is: {this.Classification()}\nThe buy day is: {this.BuyDate()}";
        }
    }
}