using _4_Infraestructure.Repositories;
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
            return new MySqlConnection("server = localhost; port = 3306; database = listas_de_compras; uid = root; password = 87651234");
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
            var sql = $"SELECT * FROM buylist WHERE Id = {id}";
            return db.QueryFirstOrDefault(sql, new { });
        }
    }
}
