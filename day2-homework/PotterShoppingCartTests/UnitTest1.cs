using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ShoppingCart;

namespace PotterShoppingCartTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Vol1_is_1_Vol2_is_0_Vol3_is_0_Vol4_is_0_Vol5_is_0_Sum_Should_Be_100()
        {
            //arrange
            var products = new List<Product>()
                            {
                                new Product() { Name = "HP1", Price = 100 }
                            };

            PotterShoppingCart target = new PotterShoppingCart();

            //act
            double actual = target.Sum(products);
            double expected = 100;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Vol1_is_1_Vol2_is_1_Vol3_is_0_Vol4_is_0_Vol5_is_0_Sum_Should_Be_190()
        {
            //arrange
            var products = new List<Product>()
                            {
                                new Product() { Name = "HP1", Price = 100 },
                                new Product() { Name = "HP2", Price = 100 }
                            };

            PotterShoppingCart target = new PotterShoppingCart();

            //act
            double actual = target.Sum(products);
            double expected = 190;

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
