using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras
{
    public class Product
    {
        private string name;
        private string brand;
        private int quantity;
        private string category;

        public Product(string name, string brand, int quantity, string category)
        {
            this.ShouldHaveValidName(name);
            this.ShouldHaveValidBrand(brand);
            this.ShouldHaveValidCategory(category);
            this.ShouldHaveValidQuantity(quantity);

            this.name = name;
            this.brand = brand;
            this.quantity = quantity;
            this.category = category;
        }
        private void ShouldHaveValidName(string name)
        {
            if (name.Length < 2 || name.Length > 20)
            {
                throw new Exception("The name must have between 2 and 20 characters.");
            }
        }

        private void ShouldHaveValidBrand(string brand)
        {
            if(brand.Length < 2 || brand.Length > 25)
            {
                throw new Exception("The brand must have between 2 and 25 characters.");
            }
        }

        private void ShouldHaveValidQuantity(int quantity)
        {
            if(!(quantity >= 1 && quantity <= 12))
            {
                throw new Exception("The quantity must have between 1 and 12 unities.");
            }
        }

        private void ShouldHaveValidCategory(string category)
        {
            if (!Enum.IsDefined(typeof(Category), category))
            {
                throw new Exception("The category is not defined as such.");
            }
        }

        public string getName()
        {
            return this.name;
        }

        public string getBrand()
        {
            return this.brand;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public string getCategory()
        {
            return this.category;
        }

        public string getProduct()
        {
            return $"Product name: {this.getName()}\nBrand: {this.getBrand()}\nQuantity: {this.getQuantity()}\nCategory: {this.getCategory()}";
        }
    }
}
