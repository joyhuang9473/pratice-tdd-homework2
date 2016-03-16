using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {

        [TestMethod]
        public void TestCheckout_第1集_1本_總價格應為_100()
        {
            // arrange
            var target = new PotterShoppingCart();
            var orderList = new List<Order>
            {
                new Order { SerialNum = 1, Number = 1 }
            };

            target.AddOrders(orderList);

            // act
            var actual = target.Checkout();

            // assert
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }
    }
}