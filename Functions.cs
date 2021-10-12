using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne
{
    class Functions
    {
        static void Main()
        {
            int x=20, y = 10;
            Console.WriteLine("Sum of {0} and {1} is {2}" , x, y , (x+y));

            Console.WriteLine("Difference of {0} and {1} is {2}", x, y, (x - y));

            Console.WriteLine("Product of {0} and {1} is {2}", x, y, (x * y));


            Console.WriteLine("Quotient of {0} and {1} is {2}", x, y, (x / y));

            Console.WriteLine("Remainder of {0} and {1} is {2}", x, y, (x % y));



        }
    }
}
