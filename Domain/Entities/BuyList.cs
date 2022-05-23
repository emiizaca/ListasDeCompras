﻿using ListasDeCompras.Domain.Repositories;
using ListasDeCompras.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeCompras.Domain.Entities
{
    public class BuyList
    {
        private Identity id;
        private Name name;
        private Classification classification;
        private BuyDateOfOneWeek buyDate;

        private BuyListRepository repository;

        public BuyList(Guid id, string name, string classification, DateTime buyDate, BuyListRepository repository)
        {
            this.id = new Identity(id);
            this.name = new Name(name);
            this.classification = new Classification(classification);
            this.buyDate = new BuyDateOfOneWeek(buyDate);
            this.repository = repository;
        }

        public static BuyList CreateNewBuyList(string name, string classification, DateTime buyDate,BuyListRepository repository)
        {
            return new BuyList(Guid.NewGuid(), name, classification, buyDate, repository);
        }

        public Guid Id()
        {
            return this.id.Value();
        }
        public string Name()
        {
            return this.name.Value();
        }
        public string Classification()
        {
            return this.classification.Value();
        }
        public DateTime BuyDate()
        {
            return this.buyDate.Value();
        }
        public string DataList()
        {
            return $"List name: {this.Name()}\nThe classification is: {this.Classification()}\nThe buy day is: {this.BuyDate()}";
        }

        public void Save()
        {
            this.repository.Add(this);
        }
    }
}