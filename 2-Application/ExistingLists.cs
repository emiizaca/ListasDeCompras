using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Application
{ 
    public class ExistingLists
    {
        private BuyListRepository repository;

        public ExistingLists(BuyListRepository repository)
        {
            this.repository = repository;
        }

        public List<BuyList> Execute()
        {
            return this.repository.GetAll();
        }
    }
}
