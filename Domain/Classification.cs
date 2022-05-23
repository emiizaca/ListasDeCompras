using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public class Classification
    {
        private string value;
        public Classification(string classification)
        {
            this.ShouldHaveValidClassification(classification);
            this.value = classification;
        }
        private void ShouldHaveValidClassification(string classification)
        {
            if (!Enum.IsDefined(typeof(Classifications), classification))
            {
                throw new Exception("The classification is not defined as such.");
            }
        }
        public string Value()
        {
            return this.value;
        }
    }
}