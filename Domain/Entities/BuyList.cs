using ListasDeCompras.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.Entities
{
    public class BuyList
    {
        private Identity id;
        private Name name;
        private Classification classification;
        private BuyDateOfOneWeek buyDate;
        private List<Product> products = new List<Product>();
        public BuyList(Guid id, string name, string classification, DateTime buyDate)
        {
            this.id = new Identity(id);
            this.name = new Name(name);
            this.classification = new Classification(classification);
            this.buyDate = new BuyDateOfOneWeek(buyDate);
        }
        public static BuyList CreateNewBuyList(string name, string classification, DateTime buyDate)
        {
            return new BuyList(Guid.NewGuid(), name, classification, buyDate);
        }

        public void  AddProduct(Product product)
        {
            products.Add(product);
        }

        //todo: public void DeleteProduct();

        public Guid Id()
        {
            return this.id.Value();
        }
        public string Name()
        {
            return this.name.Value();
        }
        public string Classification()
        {
            return this.classification.Value();
        }
        public DateTime BuyDate()
        {
            return this.buyDate.Value();
        }

        public List<Product> Products()
        {
            return this.products;
        }
        public string DataList()
        {
            return $"List name: {this.Name()}\nThe classification is: {this.Classification()}\nThe buy day is: {this.BuyDate()}";
        }
    }
}