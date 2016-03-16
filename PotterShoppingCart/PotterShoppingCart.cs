using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        private const int POTTER_BOOK_PRICE = 100;

        private enum DiscountDegree
        {
            TWO_KIND_BOOKS = 2,
            THREE_KIND_BOOKS,
            FOUR_KIND_BOOKS,
            FIVE_KIND_BOOKS
        }

        private List<Order> _orderList;

        /**
        *  _quantityOfPotterBook[POTTER_BOOK_X]
        *   : the quantity of Potter Book X
        *   : X = 1, 2, 3, ...
        */
        private int[] _quantityOfPotterBook;

        public PotterShoppingCart()
        {
            this._orderList = null;
            this._quantityOfPotterBook = new int[] { -1, -1, -1, -1, -1 };
        }

        public void AddOrders(List<Order> orderList)
        {
            this._orderList = orderList;
        }

        public double Checkout()
        {
            double totalPrice = 0;

            CalculateBookQuantities();

            while (HasSpecialPrice())
            {
                totalPrice += CalculateSpecialPrice();

                AccessOrders();
            }

            totalPrice += CalculateOriginalPrice();

            return totalPrice;
        }

        private void CalculateBookQuantities()
        {
            for (var i = 0; i < _orderList.Count; i++)
            {
                var serialNum = this._orderList[i].SerialNum;
                this._quantityOfPotterBook[serialNum-1] = this._orderList[i].Quantity;
            }
        }

        private double CalculateSpecialPrice()
        {
            double specialPriceRatio = 0;
            int quantity = 0;

            switch (GetDiscountDegree())
            {
                case DiscountDegree.FIVE_KIND_BOOKS:
                    specialPriceRatio = 0.75;
                    quantity = 5;
                    break;
                case DiscountDegree.FOUR_KIND_BOOKS:
                    specialPriceRatio = 0.8;
                    quantity = 4;
                    break;
                case DiscountDegree.THREE_KIND_BOOKS:
                    specialPriceRatio = 0.9;
                    quantity = 3;
                    break;
                case DiscountDegree.TWO_KIND_BOOKS:
                    specialPriceRatio = 0.95;
                    quantity = 2;
                    break;
                default:
                    break;
            }

            return POTTER_BOOK_PRICE * quantity * specialPriceRatio;
        }

        private double CalculateOriginalPrice()
        {
            var price = 0;

            foreach (var quantity in this._quantityOfPotterBook)
            {
                if (quantity >= 1)
                {
                    price += POTTER_BOOK_PRICE * quantity;
                }
            }

            return price;
        }

        private DiscountDegree GetDiscountDegree()
        {
            return (DiscountDegree)this._quantityOfPotterBook.Count(n => n >= 1);
        }

        private bool HasSpecialPrice()
        {
            if (this._quantityOfPotterBook.Count(n => n >= 1) >= 2)
            {
                return true;
            }

            return false;
        }

        private void AccessOrders()
        {
            for (var i = 0; i < this._quantityOfPotterBook.Length; i++)
            {
                this._quantityOfPotterBook[i] -= 1;
            }
        }

    }
}
