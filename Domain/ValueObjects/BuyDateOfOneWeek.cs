using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.ValueObjects
{
    public class BuyDateOfOneWeek
    {
        private DateTime value;

        public BuyDateOfOneWeek(DateTime buyDate)
        {
            this.ShouldBeAWeekFromNow(buyDate);
            this.value = buyDate;
        }
        private void ShouldBeAWeekFromNow(DateTime buyDate)
        {
            DateTime today = DateTime.Today;
            DateTime week = today.AddDays(7);
            if (!(buyDate >= today && buyDate <= week))
            {
                throw new Exception("The date should be a week from now.");
            }
        }
        public DateTime Value()
        {
            return this.value;
        }
    }
}
