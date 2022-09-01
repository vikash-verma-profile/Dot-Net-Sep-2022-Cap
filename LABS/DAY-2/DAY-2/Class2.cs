using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2
{
    //switch 
    class Class2
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            //string==>Int
            //type casting
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Case 1 is executed");
                    break;
                case 2:
                    Console.WriteLine("Case 2 is executed");
                    break;
                default:
                    Console.WriteLine("Please enter a valid Input");
                    break;
            }
        }
    }
}
