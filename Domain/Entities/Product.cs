using ListasDeCompras.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.Entities
{
    public class Product
    {
        [Key]
        private Identity id;
        private Identity buyListId;
        private Name name;
        private Brand brand;
        private Quantity quantity;
        private Category category;

        public Product(Guid id, Guid buyListId, string name, string brand, int quantity, string category)
        { 
            this.id = new Identity(id);
            this.buyListId = new Identity(buyListId);
            this.name = new Name(name);
            this.brand = new Brand(brand);
            this.quantity = new Quantity(quantity);
            this.category = new Category(category);
        }

        public static Product CreateNewProduct(Guid buyListId, string name, string brand, int quantity, string category)
        {
            return new Product(Guid.NewGuid(), buyListId , name, brand, quantity, category);
        }
        public Guid Id()
        {
            return this.id.Value();
        }

        public Guid BuyListId()
        {
            return this.buyListId.Value();
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
