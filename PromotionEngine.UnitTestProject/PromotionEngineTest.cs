using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.BusinessRules.PromotionProduct;
using PromotionEngine.Main;

namespace PromotionEngine.UnitTestProject
{
    [TestClass]
    public class PromotionEngineTest
    {
        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_ScenarioA()
        {
            //Arrange
            List<string> carts = new List<string>(){ "A","B","C"};
            int ExpectedTotalPrice = 100;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = CalculateCartTotalPrice.CalculateTotalPrice(carts);

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }

        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_ScenarioB()
        {
            //Arrange
            List<string> carts = new List<string>() { "A", "B", "A", "B", "A", "B", "A", "B", "C", "A", "B" };
            int ExpectedTotalPrice = 370;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = CalculateCartTotalPrice.CalculateTotalPrice(carts);

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }

        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_ScenarioC()
        {
            //Arrange
            List<string> carts = new List<string>() { "A", "B", "A", "B", "B", "C", "B", "D", "A", "B" };
            int ExpectedTotalPrice = 280;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = CalculateCartTotalPrice.CalculateTotalPrice(carts);

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }

        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_SKU_A()
        {
            //Arrange
            PromotionSKU_A _promotionSKU_A = new PromotionSKU_A("A", 5);
            int ExpectedTotalPrice = 230;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = _promotionSKU_A.CalculatePrice();

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }

        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_SKU_B()
        {
            //Arrange
            PromotionSKU_B _promotionSKU_B = new PromotionSKU_B("B", 5);
            int ExpectedTotalPrice = 120;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = _promotionSKU_B.CalculatePrice();

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }

        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_SKU_C()
        {
            //Arrange
            PromotionSKU_C _promotionSKU_C = new PromotionSKU_C("C", 5, true);
            int ExpectedTotalPrice = 150;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = _promotionSKU_C.CalculatePrice();

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }

        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_SKU_D()
        {
            //Arrange
            PromotionSKU_D _promotionSKU_D = new PromotionSKU_D("D", 5,true);
            int ExpectedTotalPrice = 150;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = _promotionSKU_D.CalculatePrice();

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }

        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_SKU_C_False()
        {
            //Arrange
            PromotionSKU_C _promotionSKU_C = new PromotionSKU_C("C", 5, false);
            int ExpectedTotalPrice = 100;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = _promotionSKU_C.CalculatePrice();

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }

        [TestMethod]
        public void CalculateTotalPriceWithActivePromotion_SKU_D_False()
        {
            //Arrange
            PromotionSKU_D _promotionSKU_D = new PromotionSKU_D("D", 5, false);
            int ExpectedTotalPrice = 75;
            int ActualTotalPrice = 0;

            //Act
            ActualTotalPrice = _promotionSKU_D.CalculatePrice();

            //Assert
            Assert.AreEqual(ExpectedTotalPrice, ActualTotalPrice);

        }
    }
}
