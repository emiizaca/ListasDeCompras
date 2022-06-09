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
        private Identity id;
        private Brand brand;
        private Quantity quantity;
        private Category category;

        public Product(Guid id, string name, string brand, int quantity, string category)
        {
            this.id = new Identity(id);
            this.name = new Name(name);
            this.brand = new Brand(brand);
            this.quantity = new Quantity(quantity);
            this.category = new Category(category);
        }

        public static Product CreateNewProduct(string name, string brand, int quantity, string category)
        {
            return new Product(Guid.NewGuid(), name, brand, quantity, category);
        }

        public string Name()
        {
            return this.name.Value();
        }
        public Guid Id()
        {
            return this.id.Value();
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
