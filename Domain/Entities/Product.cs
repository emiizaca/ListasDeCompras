using ListasDeCompras.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.Entities
{
    public class Product
    {
        private Name name;
        private Brand brand;
        private Quantity quantity;
        private Category category;

        public Product(string name, string brand, int quantity, string category)
        {
            this.name = new Name(name);
            this.brand = new Brand(brand);
            this.quantity = new Quantity(quantity);
            this.category = new Category(category);
        }
        public string Name()
        {
            return this.name.Value();
        }
        public string Brand()
        {
            return this.brand.Value();
        }
        public int Quantity()
        {
            return this.quantity.Value();
        }
        public string Category()
        {
            return this.category.Value();
        }
        public string getProduct()
        {
            return $"Product name: {this.Name()}\nBrand: {this.Brand()}\nQuantity: {this.Quantity()}\nCategory: {this.Category()}";
        }
    }
}
