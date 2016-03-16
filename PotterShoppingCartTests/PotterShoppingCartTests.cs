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
                new Order { SerialNum = 1, Quantity = 1 }
            };

            target.AddOrders(orderList);

            // act
            var actual = target.Checkout();

            // assert
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckout_第1集_1本_第2集_1本_總價格應為_190()
        {
            // arrange
            var target = new PotterShoppingCart();
            var orderList = new List<Order>
            {
                new Order { SerialNum = 1, Quantity = 1 },
                new Order { SerialNum = 2, Quantity = 1 }
            };

            target.AddOrders(orderList);

            // act
            var actual = target.Checkout();

            // assert
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckout__第1_2_3_集_各_1本_總價格應為_270()
        {
            // arrange
            var target = new PotterShoppingCart();
            var orderList = new List<Order>
            {
                new Order { SerialNum = 1, Quantity = 1 },
                new Order { SerialNum = 2, Quantity = 1 },
                new Order { SerialNum = 3, Quantity = 1 }
            };

            target.AddOrders(orderList);

            // act
            var actual = target.Checkout();

            // assert
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckout_第1_2_3_4_集_各_1本_總價格應為_320()
        {
            // arrange
            var target = new PotterShoppingCart();
            var orderList = new List<Order>
            {
                new Order { SerialNum = 1, Quantity = 1 },
                new Order { SerialNum = 2, Quantity = 1 },
                new Order { SerialNum = 3, Quantity = 1 },
                new Order { SerialNum = 4, Quantity = 1 }
            };

            target.AddOrders(orderList);

            // act
            var actual = target.Checkout();

            // assert
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckout_第1_2_3_4_5集_各_1本_總價格應為_375()
        {
            // arrange
            var target = new PotterShoppingCart();
            var orderList = new List<Order>
            {
                new Order { SerialNum = 1, Quantity = 1 },
                new Order { SerialNum = 2, Quantity = 1 },
                new Order { SerialNum = 3, Quantity = 1 },
                new Order { SerialNum = 4, Quantity = 1 },
                new Order { SerialNum = 5, Quantity = 1 }
            };

            target.AddOrders(orderList);

            // act
            var actual = target.Checkout();

            // assert
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckout_第1_2_集_各_1本_第3集_2本_總價格應為_370()
        {
            // arrange
            var target = new PotterShoppingCart();
            var orderList = new List<Order>
            {
                new Order { SerialNum = 1, Quantity = 1 },
                new Order { SerialNum = 2, Quantity = 1 },
                new Order { SerialNum = 3, Quantity = 2 }
            };

            target.AddOrders(orderList);

            // act
            var actual = target.Checkout();

            // assert
            var expected = 370;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckout_第1集_1本_第2_3集_各_2本_總價格應為_460()
        {
            // arrange
            var target = new PotterShoppingCart();
            var orderList = new List<Order>
            {
                new Order { SerialNum = 1, Quantity = 1 },
                new Order { SerialNum = 2, Quantity = 2 },
                new Order { SerialNum = 3, Quantity = 2 }
            };

            target.AddOrders(orderList);

            // act
            var actual = target.Checkout();

            // assert
            var expected = 460;
            Assert.AreEqual(expected, actual);
        }

    }
}