using ListasDeCompras.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.Repositories
{
    public class BuyListInMemoryRepository: BuyListRepository
    {
        private List<BuyList> buyLists = new List<BuyList>();

        public void Add(BuyList buyList)
        {
            this.buyLists.Add(buyList);
        }

        public List<BuyList> GetAll()
        {
            return this.buyLists;
        }

        public BuyList getById(Guid id)
        {
            return this.buyLists.Find(buyList => buyList.Id() == id);
        }
    }
}
