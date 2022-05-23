using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public class Brand:StringValueObject
    {
        public Brand(string brand)
        {
            this.ShouldHaveValidBrand(brand);
            this.value = brand;
        }

        private void ShouldHaveValidBrand(string brand)
        {
            if (brand.Length < 2 || brand.Length > 25)
            {
                throw new Exception("The brand must have between 2 and 25 characters.");
            }
        }
    }
}
