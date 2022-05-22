using ListasDeCompras;
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
            BuyList bl = new BuyList(
                "Lista de compras",
                "car",
                DateTime.Today
                );

            //Act
            string classification = bl.Classification();

            //Assert
            Assert.Equal("car", classification);
        }
    }
}
