using ListasDeCompras.Infraestructure.Repositories;
using Dapper;
using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListasDeCompras.Infraestructure.Repositories
{
    public class BuyListMySQLRepository: BuyListRepository
    {
        //MySQLConfiguration mySQLConnectionConfig = new MySQLConfiguration(ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString);
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection("server = localhost; port = 3306; database = listas_de_compras; uid = root; password = 87654321");
        }
        public void Add(BuyList buyList)
        {
            var db = dbConnection();
            var sql = $"INSERT INTO buylist (id, name, classification, buyDate) VALUES ('{buyList.Id()}', '{buyList.Name()}', '{buyList.Classification()}', '{buyList.BuyDate().ToString("yyyy-MM-dd")}')";
            db.Execute(sql, new { });
        }

        public List<BuyList> GetAll()
        {
            var db = dbConnection();
            var sql = $"SELECT * FROM buylist";
            return db.Query<BuyList>(sql).ToList();
        }

        public BuyList getById(Guid id)
        {
            var db = dbConnection();
            var sql = $"SELECT * FROM buylist WHERE id = {id}";
            return db.QueryFirstOrDefault(sql, new { });
        }

        public void Update(BuyList buyList, Guid id)
        {
            var db = dbConnection();
            var sql = $"UPDATE buylist SET id= '{buyList.Id()}', name= '{buyList.Name()}', classification= '{buyList.Classification()}', buyDate= '{buyList.BuyDate().ToString("yyyy-MM-dd")}' WHERE Id= {id}";
            db.Execute(sql, new { });
        }
        public void Delete(Guid id)
        {
            var db = dbConnection();
            var sql = $"DELETE FROM buylist WHERE id= {id} ";
            db.Execute(sql, new { });
        }
    }
}
