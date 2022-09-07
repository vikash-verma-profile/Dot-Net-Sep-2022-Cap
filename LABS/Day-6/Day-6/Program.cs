using System;

namespace Day_6
{
    //static
    //local static and instance variables

    class B
    {
        //instance variable
        int a;
        public B(int a)
        {
            //local scope
            this.a = a;//this is the keyword that will point to current class object
        }
        public void print()
        {
            Console.WriteLine("Value of a is "+a);
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
           
            B b = new B(1);
            b.print();
            B b1 = new B(2);
            b1.print();
        }
    }
}
