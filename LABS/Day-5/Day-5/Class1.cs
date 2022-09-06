using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    /// <summary>
    /// interfaces
    /// abstarct
    /// 
    /// static
    /// virtual
    /// base
    /// override
    /// operator
    /// sealed
    /// </summary>
    /// 
   abstract class abc
    {
        abstract public void print();
        public void show()
        {
            Console.WriteLine("asdasd");
        }
    }
    class ABC2 : abc
    {
        int a=1;
        int b=2;
        public override void print()
        {
            Console.WriteLine("I am print Method");
        }
        public override string ToString()
        {
            return "a= "+a+"b= "+b;
        }

    }
    class Class1
    {
        public static void Main()
        {
            //1.ToString();
            ABC2 abc = new ABC2();
            string sampl=abc.ToString();
            Console.WriteLine(sampl);
        }
    }
}
