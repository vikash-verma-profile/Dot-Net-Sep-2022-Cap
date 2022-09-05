using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// abstract class or abstract
    /// </summary>
    /// 

    /*
     * We cannot create an instance of a abstract class
     * abstract method cannot have a body into base class or the class in which we define
     * if we make a method as abstract then we have to give the defination into derived class
     * for implentation we have to use override keyword in dervied class
     */

   abstract class DummyS
    {
        public void show()
        {
            Console.WriteLine("Hi I am from abstract class");
        }
        abstract public void Absshow();
       
    }
    class DerviedDummy:DummyS
    {
        public override void Absshow()
        {
            Console.WriteLine("Hi I am from abstract class");
        }
        public void print()
        {
            Console.WriteLine("I am from derived");
        }
    }
    class Class8
    {
        public static void Main9()
        {
            DerviedDummy s = new DerviedDummy();
            s.show();
            s.print();

        }
    }
}
