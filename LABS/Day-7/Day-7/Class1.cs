using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    //static keyword
    /// <summary>
    /// classes
    /// variables
    /// methods
    /// 
    /// constructors
    /// </summary>
    /// 

    //static class cannot have non static members and methods
    static class A
    {
        public static int a;
        public static void Print()
        {
            Console.WriteLine(a);
        }
    }
    class B
    {
        public static int a;
        public int b;
        static B()
        {
            a = 1; //only static members can be intiated
                   // b = 3;
            Console.WriteLine("Hi i am from static ");
        }
        public B()
        {
            b = 1;
            a = 2;
            Console.WriteLine("Hi i am from default constructor");
        }
        public void Print()
        {
            Console.WriteLine("a= "+a+"b= "+b);
        }
        public static void Show()
        {
            Console.WriteLine("a= " + a );
        }
    }
    class Class1
    {
        public static void Main2()
        {
             B b = new B();
            //b.Print();
            //B.Show();
        }
    }
}
