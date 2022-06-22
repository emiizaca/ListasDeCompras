using ListasDeCompras.Application.DTO;
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
        public void Execute(BuyListCreationDTO buyListCreationDTO)
        {
            this.repository.Add(
                BuyList.CreateNewBuyList(
                    buyListCreationDTO.Name(),
                    buyListCreationDTO.Classification(),
                    buyListCreationDTO.BuyDate()
                )
            );
        }
    }
}
