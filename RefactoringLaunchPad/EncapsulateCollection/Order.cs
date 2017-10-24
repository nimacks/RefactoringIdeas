using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLaunchPad.EncapsulateCollection
{
    public class Order
    {
        private List<OrderLine> _orderLines;
        private int _orderTotal;

        public IEnumerable<OrderLine> OrderLine { get { return _orderLines; } }

        public void AddOrderLine(OrderLine orderLine)
        {
            _orderTotal += orderLine.Total;
            _orderLines.Add(orderLine);
        }

        public void RemoveOrderLine(OrderLine orderLine)
        {
            _orderTotal -= orderLine.Total;
            _orderLines.Remove(orderLine);
        }
    }


    public class OrderLine
    {
        public int Total { get; set; }
    }
}
