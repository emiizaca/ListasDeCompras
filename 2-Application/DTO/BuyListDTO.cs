using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Application.DTO
{
    public class BuyListDTO
    {
        private Guid id;
        private string name;
        private string classification;
        private DateTime buyDate;

        public BuyListDTO(Guid id, string name, string classification, DateTime buyDate)
        {
            this.id = id;
            this.name = name;
            this.classification = classification;
            this.buyDate = buyDate;
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
        public string DataList()
        {
            return $"Id: {this.Id()}\nList name: {this.Name()}\nThe classification is: {this.Classification()}\nThe buy day is: {this.BuyDate()}";
        }
    }
}