using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2
{
    class Class1
    {
        public static void Main()
        {
            //maximum of 3 numbers
            //1,2,3
            int a = 10, b = 5, c = 3;
           // int max = a;
            if (a>b && a>c)
            {
                Console.WriteLine("A  is max");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is max");
            }
            else
            {
                Console.WriteLine("C is MAx");
            }
        }
    }
}
