using RefactoringLaunchPad.EncapsulateCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var onlineOrder = new Order();
            onlineOrder.AddOrderLine(new OrderLine(){Total = 123});
            onlineOrder.RemoveOrderLine(new OrderLine(){Total = 123});


        }
    }

}
