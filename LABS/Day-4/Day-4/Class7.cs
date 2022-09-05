using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// Types of Inheritance
    /// 1.Single level Inheritance
    /// 2.Multi Level Inheritance
    /// 3.Multiple Inheritance
    /// 4.Herarical Inheritance
    /// 5.Hybrid Inheritance
    /// </summary>
    /// 
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class Dog:Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking");
        }
    }
    class BabyDog:Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping......");
        }

    }
    class Class7
    {
        public static void Main8()
        {
            BabyDog d1 = new BabyDog();
            d1.eat();
            d1.bark();
            d1.weep();
        }
    }
}
