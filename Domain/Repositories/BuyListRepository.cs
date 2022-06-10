using ListasDeCompras.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.Repositories
{
    public interface BuyListRepository
    {
        public void Add(BuyList buyList);
        public List<BuyList> GetAll();
        public BuyList getById(Guid id);
    }
}
