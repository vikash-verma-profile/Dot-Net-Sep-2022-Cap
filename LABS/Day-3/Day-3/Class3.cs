using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{

    //call by value vs call by refrence
    class Class3
    {
        public static void Swap(int a,int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Values after Swapping a= "+a+" b= "+b);
        }
        public static void Main4()
        {
            int a=1, b=2;
            Console.WriteLine("Values Before Swapping a= " + a + " b= " + b);
            Swap(a, b);
            Console.WriteLine("Value after swapping Inside Main a= "+a+" b= "+b);
        }
    }
}
