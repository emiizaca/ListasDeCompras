using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public abstract class StringValueObject
    {
        protected string value;

        public string Value()
        {
            return this.value;
        }
    }
}
