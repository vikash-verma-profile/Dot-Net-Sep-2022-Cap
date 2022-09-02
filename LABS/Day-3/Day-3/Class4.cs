using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    //keyword
    class Class4
    {
        public static void Swap(ref int a,ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Values after Swapping a= " + a + " b= " + b);
        }
        public static void Main()
        {
            int a = 1, b = 2;
            Console.WriteLine("Values Before Swapping a= " + a + " b= " + b);
            Swap(ref a, ref b);
            Console.WriteLine("Value after swapping Inside Main a= " + a + " b= " + b);
        }
    }
}
