using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.ValueObjects
{
    public class Identity
    {
        private Guid value;

        public Identity(Guid value)
        {
            this.value = value;
        }
        public Guid Value()
        {
            return this.value;
        }
    }
}
