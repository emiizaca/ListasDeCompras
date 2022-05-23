using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.ValueObjects
{
    public class Quantity
    {
        private int value;
        public Quantity(int quantity)
        {
            this.ShouldHaveValidQuantity(quantity);
            this.value = quantity;
        }
        private void ShouldHaveValidQuantity(int quantity)
        {
            if (!(quantity >= 1 && quantity <= 12))
            {
                throw new Exception("The quantity must have between 1 and 12 unities.");
            }
        }
        public int Value()
        {
            return this.value;
        }
    }
}
