using _4_Infraestructure.Repositories;
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
    public class BuyListEFRepository: BuyListRepository
    {

        public void Add(BuyList buyList)
        {
            using var context = new DatabaseContext();
            context.buyLists.Add(buyList);
            context.SaveChanges();
        }

        public List<BuyList> GetAll()
        {
            using var context = new DatabaseContext();
            return context.buyLists.ToList();
        }

        public BuyList getById(Guid id)
        {
            using var context = new DatabaseContext();
            List<BuyList> buyLists = context.buyLists.ToList();
            return buyLists.Find(buyList => buyList.Id().Equals(id));
        }
    }
}
