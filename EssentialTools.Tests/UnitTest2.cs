using System;
using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Product[] products = {
            new Product {Name = "Kajak", Category="Sporty wodne", Price = 275M},
            new Product {Name = "Kamizelka ratunkowa", Category="Sporty wodne", Price = 48.95M},
            new Product {Name = "Piłka nożna", Category="Piłka nożna", Price = 19.50M},
            new Product {Name = "Flaga narożna", Category="Piłka nożna", Price = 34.95M}};

        [TestMethod]
        public void Sum_Products_Correctly()
        {
            var discounter = new MinimumDiscountHelper();
            var target = new LinqValueCalculator(discounter);
            var goalTotal = products.Sum(p => p.Price);

            var result = target.ValueProducts(products);

            Assert.AreEqual(goalTotal, result);
        }
    }
}
