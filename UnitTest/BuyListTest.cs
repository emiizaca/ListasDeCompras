using ListasDeCompras.Domain.Entities;
using System;
using Xunit;

namespace UnitTest
{
    public class BuyListTest
    {
        [Fact]
        public void BuyList_Classification_ValidClassification()
        {
            //Arrange
            BuyList bl = BuyList.CreateNewBuyList(
                "Lista de compras",
                "car",
                DateTime.Today
                );

            //Act
            string classification = bl.Classification();

            //Assert
            Assert.Equal("car", classification);
        }

        [Fact]
        public void BuyList_BuyDate_ValidBuyDate()
        {
            //Arrange & Act
            BuyList bl;
            Action act = () => bl = BuyList.CreateNewBuyList(
                "Lista de compras",
                "car",
                DateTime.Parse("2021-6-28")
                );

            //Assert
            Exception exception = Assert.Throws<Exception>(act);
        }
    }
}
