using System;

namespace Day_3
{
    /// <summary>
    /// 
    /// </summary>
    /// 
    //Single line comment

    /*
     * 
     * 
     */
    //switch  and type casting
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;//4 bytes
            double b = a;//Promotion 8 bytes implicit

            double c = 3.25;
            a = (int)c;//demotion and this is explicit conversion
            Console.WriteLine(a);
            Console.WriteLine(b);

            //Convert class
            //int.parse
            //int.tryparse
            Console.WriteLine("Please enter some number");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input value given by user is "+Number1);
        }
    }
}
