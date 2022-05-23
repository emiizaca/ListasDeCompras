using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public class Name : StringValueObject
    {
        public Name(string name)
        {
            this.ShouldHaveValidName(name);
            this.value = name;
        }
        private void ShouldHaveValidName(string name)
        {
            if (name.Length < 2 || name.Length > 30)
            {
                throw new Exception("The name must have between 2 and 30 characters.");
            }
        }
    }
}
