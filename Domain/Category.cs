using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public class Category
    {
        private string value;
        public Category(string category)
        {
            this.ShouldHaveValidCategory(category);
            this.value = category;
        }
        private void ShouldHaveValidCategory(string category)
        {
            if (!Enum.IsDefined(typeof(Categories), category))
            {
                throw new Exception("The category is not defined as such.");
            }
        }
        public string Value()
        {
            return this.value;
        }
    }
}
