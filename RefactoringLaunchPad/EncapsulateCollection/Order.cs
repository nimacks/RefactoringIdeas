using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLaunchPad.EncapsulateCollection
{
    public class Order
    {
        private int _orderTotal;

        public List<OrderLine> OrderLines { get; }

        public void AddOrderLine(OrderLine orderLine)
        {
            _orderTotal += orderLine.Total;
            OrderLines.Add(orderLine);
        }

        public void RemoveOrderLine(OrderLine orderLine)
        {
            _orderTotal -= orderLine.Total;
            OrderLines.Remove(orderLine);
        }
    }

    public class OrderLine
    {
        public int Total { get; set; }
    }

}
