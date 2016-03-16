using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        private List<Order> _orderList;

        public void AddOrders(List<Order> orderList)
        {
            this._orderList = orderList;
        }

        public int Checkout()
        {
            int potterBookPrice = 100;
            int result = potterBookPrice * this._orderList.Count;
            return result;
        }
    }
}
