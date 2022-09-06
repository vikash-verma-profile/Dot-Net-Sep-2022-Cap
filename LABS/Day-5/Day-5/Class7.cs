using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    /// <summary>
    /// run time polymorphism
    /// </summary>
    /// 
    class SampelA
    {
        public virtual void show()
        {
            Console.WriteLine("Hi I am from base");
        }
        public void print()
        {
            Console.WriteLine("Hi I am print from base");
        }
    }
    class SampelB:SampelA
    {
        public override void show()
        {
            Console.WriteLine("Hi I am from Derived");
        }
        public void print()
        {
            Console.WriteLine("Hi I am print from derived");
        }
    }
    class Class7
    {
        public static void Main8()
        {
            SampelA a = new SampelB();
            a.show();//example of overriding and solution
            a.print();//this was problem
        }
    }
}
