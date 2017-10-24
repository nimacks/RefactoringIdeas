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
            Order onlineOrder = new Order();
            onlineOrder.AddOrderLine(new OrderLine()
            {
                Total = 1200
            });

            Student JohnDoe = new Student();
            JohnDoe.AddClass(new Course
            {
                Id = 1,
                Name = "Principles of Biology"
            });

            JohnDoe.EnrolledCourses.Count();

            Console.WriteLine(onlineOrder.OrderLine);

        }
    }

}
