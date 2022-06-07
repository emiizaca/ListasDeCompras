using ListasDeCompras.Domain.Entities;
using ListasDeCompras.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Application
{
    public class BuyListCreator
    {
        private BuyListRepository repository;

        public BuyListCreator(BuyListRepository repository)
        {
            this.repository = repository;
        }

        public void Execute(BuyList buyList)
        {
            this.repository.Add(buyList);
        }
    }
}
