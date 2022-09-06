using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    //polymorphism
    //Compile time and run time
    //method overloading and operator overloading
    //overriding
    class MethodOverloading
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void Sum(double a,double b)
        {
            Console.WriteLine(a+b);
        }
    }
    class Class5
    {
        public static void Main()
        {
            MethodOverloading obj = new MethodOverloading();
            obj.Sum(1,2);
            obj.Sum(1, 2,3);
            obj.Sum(1.57, 2.35);
        }
    }
}
