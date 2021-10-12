using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne
{
    class Second
    {
        static void Main()
        {
            int x = 10;
            int y = 20;
            //      Console.WriteLine("Sum of x and y is " + (x+y));
            // Console.WriteLine("Sum of " + x + " and " + y + " is " + (x + y));
            Console.WriteLine("Sum of  {0}  and {1} is {2}" , x, y , (x + y));
            // printf("Sum of %d and %d is %d" ,x,y, x+y);

        }
    }
}
