using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// inheritance
    /// </summary>
    /// 
    //Base class and Dervied class

    class DummyBase
    {
        int a;
        public void Print()
        {
            Console.WriteLine("Value of a is :"+a);
        }
    }
    class DerivedClass:DummyBase
    {
        int b;
        public void Show()
        {
            Console.WriteLine("Value of b is "+b);
        }
    }
    class Class6
    {
        public static void Main7()
        {
            //DummyBase b = new DummyBase();
            //b.Print();
            DerivedClass d = new DerivedClass();
            d.Show();
            d.Print();
        }
    }
}
