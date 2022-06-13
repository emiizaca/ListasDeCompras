using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.ValueObjects
{
    public class Identity
    {
        private string value;

        public Identity(string value)
        {
            this.value = value;
        }
        public string Value()
        {
            return this.value;
        }
    }
}
