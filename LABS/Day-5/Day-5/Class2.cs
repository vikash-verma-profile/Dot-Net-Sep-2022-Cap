using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    abstract class Animal
    {
        //hidden implementing abstraction
        string Name;
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        abstract public void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }
    class Class2
    {
        public static void Main3()
        {
            Dog d = new Dog();
            d.SetName("Dummy");
            Console.WriteLine(d.GetName());
            d.Eat();
        }
    }
}
