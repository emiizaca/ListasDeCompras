using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Application.DTO
{
    public class BuyListDTO
    {
        private string name;
        private string classification;
        private DateTime buyDate;

        public BuyListDTO(string name, string classification, DateTime buyDate)
        {
            this.name = name;
            this.classification = classification;
            this.buyDate = buyDate;
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
            return $"List name: {this.Name()}\nThe classification is: {this.Classification()}\nThe buy day is: {this.BuyDate()}";
        }
    }
}