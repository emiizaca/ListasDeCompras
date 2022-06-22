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
    public class ExistingLists
    {
        private BuyListRepository repository;

        public ExistingLists(BuyListRepository repository)
        {
            this.repository = repository;
        }

        public List<BuyListDTO> Execute()
        {
            List<BuyListDTO> buyListDTO = new List<BuyListDTO>();
            foreach (BuyList actualBuyList in this.repository.GetAll())
            {
                buyListDTO.Add(
                    new BuyListDTO(
                        actualBuyList.Id(),
                        actualBuyList.Name(),
                        actualBuyList.Classification(),
                        actualBuyList.BuyDate()
                        )
                    );
            }
            return buyListDTO;
        }
    }
}
