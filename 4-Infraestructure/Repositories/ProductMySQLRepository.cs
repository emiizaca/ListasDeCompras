using ListasDeCompras.Infraestructure.Repositories;
using Dapper;
using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Infraestructure.Repositories
{
    public class ProductMySQLRepository : ProductRepository
    {
        //MySQLConfiguration mySQLConnectionConfig = new MySQLConfiguration(ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString);
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection("server = localhost; port = 3306; database = listas_de_compras; uid = root; password = 87654321");
        }
        public void Add(Product product)
        {
            var db = dbConnection();
            var sql = $"INSERT INTO product (id, buyListId, name, brand, quantity, category) VALUES ('{product.Id()}', '{product.BuyListId()}', '{product.Name()}', '{product.Brand()}', '{product.Quantity()}', '{product.Category()}')";
            db.Execute(sql, new { });
        }

        public List<Product> GetAll()
        {
            var db = dbConnection();
            var sql = $"SELECT * FROM product";
            return db.Query<Product>(sql).ToList();
        }

        public List<Product> GetByBuyListId(Guid buyListId)
        {
            var db = dbConnection();
            var sql = $"SELECT * FROM product WHERE buyListId = {buyListId}";
            return db.Query<Product>(sql).ToList();
        }

        public Product GetById(Guid id)
        {
            var db = dbConnection();
            var sql = $"SELECT * FROM product WHERE id = {id}";
            return db.QueryFirstOrDefault(sql, new { });
        }

        public void Update(Product product, Guid id)
        {
            var db = dbConnection();
            var sql = $"UPDATE product SET id= '{product.Id()}', buyListId= '{product.BuyListId()}', name= '{product.Name()}', brand= '{product.Brand()}', quantity= '{product.Quantity()}', category= '{product.Category()}' WHERE Id= {id} AND buyListId= {product.BuyListId()}";
            db.Execute(sql, new { });
        }

        public void Delete(Guid id, Guid buyListId)
        {
            var db = dbConnection();
            var sql = $"DELETE FROM product WHERE id= {id} AND buyListId= {buyListId}";
            db.Execute(sql, new { });
        }
    }
}
