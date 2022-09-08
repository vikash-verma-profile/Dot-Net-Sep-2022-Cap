using System;

namespace Day_7
{

    //static
    //properties and indexers
    //type of constructors
    //structs and enums
    //collections
    //exception handling
    //grabage collection
    //file handling
    //threads
    //partial classes and extension methods
    //Delegates
    //new features in c#8.0
    //git commands

    class SampleA
    {
        int a;
        public override string ToString()
        {
            return "value of a is "+a;
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            SampleA a = new SampleA();
            string value=a.ToString();
            Console.WriteLine(value);
        }
    }
}
