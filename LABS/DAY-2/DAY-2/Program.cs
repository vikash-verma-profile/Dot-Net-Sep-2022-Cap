using System;

namespace DAY_2
{
    class Program
    {
        static void Main1(string[] args)
        {
            int a = 5;
            int b = 71;
            int c = 36;

            Console.WriteLine(c%2);
            Console.WriteLine(c/2);

            //conditional statements
            //if else ,switch

            //<data-type> variable-name operator value
            Console.WriteLine(a+b);

            if (a > 7)
            {
                Console.WriteLine("a is greater than 7");
            }
            else
            {
                Console.WriteLine("7 is greater than a");
            }
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Value entered by you is " + name);
        }
    }
}
