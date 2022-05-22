using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public class BuyList
    {
        private Name name;
        private Classification classification;
        private BuyDateOfOneWeek buyDate;

        public BuyList(string name, string classification, DateTime buyDate)
        {
            this.name = new Name(name);
            this.classification = new Classification(classification);
            this.buyDate = new BuyDateOfOneWeek(buyDate);
        }
        public string Name()
        {
            return this.name.Value();
        }
        public string Classification()
        {
            return this.classification.Value();
        }
        public DateTime BuyDate()
        {
            return this.buyDate.Value();
        }
        public string DataList()
        {
            return $"List name: {this.Name()}\nThe classification is: {this.Classification()}\nThe buy day is: {this.BuyDate()}";
        }
    }
}