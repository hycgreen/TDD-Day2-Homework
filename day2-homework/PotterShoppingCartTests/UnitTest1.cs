﻿using System;
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

        [TestMethod]
        public void Test_Vol1_is_1_Vol2_is_1_Vol3_is_1_Vol4_is_0_Vol5_is_0_Sum_Should_Be_270()
        {
            //arrange
            var products = new List<Product>()
                            {
                                new Product() { Name = "HP1", Price = 100 },
                                new Product() { Name = "HP2", Price = 100 },
                                new Product() { Name = "HP3", Price = 100 }
                            };

            PotterShoppingCart target = new PotterShoppingCart();

            //act
            double actual = target.Sum(products);
            double expected = 270;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Vol1_is_1_Vol2_is_1_Vol3_is_1_Vol4_is_1_Vol5_is_0_Sum_Should_Be_320()
        {
            //arrange
            var products = new List<Product>()
                            {
                                new Product() { Name = "HP1", Price = 100 },
                                new Product() { Name = "HP2", Price = 100 },
                                new Product() { Name = "HP3", Price = 100 },
                                new Product() { Name = "HP4", Price = 100 },
                            };

            PotterShoppingCart target = new PotterShoppingCart();

            //act
            double actual = target.Sum(products);
            double expected = 320;

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test_Vol1_is_1_Vol2_is_1_Vol3_is_1_Vol4_is_1_Vol5_is_1_Sum_Should_Be_375()
        {
            //arrange
            var products = new List<Product>()
                            {
                                new Product() { Name = "HP1", Price = 100 },
                                new Product() { Name = "HP2", Price = 100 },
                                new Product() { Name = "HP3", Price = 100 },
                                new Product() { Name = "HP4", Price = 100 },
                                new Product() { Name = "HP5", Price = 100 }
                            };

            PotterShoppingCart target = new PotterShoppingCart();

            //act
            double actual = target.Sum(products);
            double expected = 375;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Vol1_is_1_Vol2_is_1_Vol3_is_2_Vol4_is_0_Vol5_is_0_Sum_Should_Be_370()
        {
            //arrange
            var products = new List<Product>()
                            {
                                new Product() { Name = "HP1", Price = 100 },
                                new Product() { Name = "HP2", Price = 100 },
                                new Product() { Name = "HP3", Price = 100 },
                                new Product() { Name = "HP3", Price = 100 }
                            };

            PotterShoppingCart target = new PotterShoppingCart();

            //act
            double actual = target.Sum(products);
            double expected = 370;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Vol1_is_1_Vol2_is_2_Vol3_is_2_Vol4_is_0_Vol5_is_0_Sum_Should_Be_460()
        {
            //arrange
            var products = new List<Product>()
                            {
                                new Product() { Name = "HP1", Price = 100 },
                                new Product() { Name = "HP2", Price = 100 },
                                new Product() { Name = "HP2", Price = 100 },
                                new Product() { Name = "HP3", Price = 100 },
                                new Product() { Name = "HP3", Price = 100 }
                            };

            PotterShoppingCart target = new PotterShoppingCart();

            //act
            double actual = target.Sum(products);
            double expected = 460;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
