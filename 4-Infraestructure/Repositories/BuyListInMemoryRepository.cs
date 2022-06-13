using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Infraestructure.Repositories
{
    public class BuyListInMemoryRepository : DataBaseContext, BuyListRepository
    {

        public BuyListInMemoryRepository(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public void Add(BuyList buyList)
        {
            this.BuyLists.Add(buyList);
            this.SaveChanges();
        }

        public List<BuyList> GetAll()
        {
            return this.BuyLists.ToList<BuyList>();
        }

        public BuyList getById(string id)
        {
            return this.BuyLists.SingleOrDefault(x => x.Id() == id);
            //return this.buyLists.Find(buyList => buyList.Id() == id);
        }
    }
}
