using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public class BuyList
    {
        private string name;
        private string classification;
        private DateTime dateOfBuy;

        public BuyList(string name, string classification, DateTime dateOfBuy)
        {
            this.ShouldHaveValidName(name);
            this.ShouldHaveValidClassification(classification);
            this.ShouldBeAWeekFromNow(dateOfBuy);

            this.name = name;
            this.classification = classification;
            this.dateOfBuy = dateOfBuy;
        }

        private void ShouldHaveValidName(string name)
        {
            if (name.Length < 5 || name.Length > 30)
            {
                throw new Exception("The name must have between 3 and 30 characters.");
            }
        }

        private void ShouldHaveValidClassification(string classification)
        {
            if (!Enum.IsDefined(typeof(Classification), classification))
            {
                throw new Exception("The classification is not defined as such.");
            }
        }

        private void ShouldBeAWeekFromNow(DateTime dateOfBuy)
        {
            DateTime today = DateTime.Today;
            DateTime week = today.AddDays(7);
            if(!(dateOfBuy >= today && dateOfBuy <= week))
            {
                throw new Exception("The date should be a week from now.");
            }
        }

        public string getName()
        {
            return this.name;
        }

        public string getClassification()
        {
            return this.classification;
        }

        public DateTime getDateOfBuy()
        {
            return this.dateOfBuy;
        }

        public string DataList()
        {
            return $"List name: {this.getName()}\nThe classification is: {this.getClassification()}\nThe buy day is: {this.getDateOfBuy()}";
        }
    }

}
