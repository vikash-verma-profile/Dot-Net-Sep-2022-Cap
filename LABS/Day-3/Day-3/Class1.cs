using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    /// <summary>
    /// functions/methods
    /// </summary>
    class Class1
    {

        //escape characters \n=> new line
        /// <summary>
        /// \t for tabs
        /// </summary>
        public static void Main2()
        {
            Console.WriteLine("Please enter a choice what you want to do \n 1.ADD \n 2.Sub \n 3.Mul \n 4.Division");
            int Choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of Number 1:");
            int Number1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of Number 2:");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine(Number1+"+"+Number2+"="+ (Number1+Number2));
                    break;
                case 2:
                    Console.WriteLine(Number1 + "-" + Number2 + "=" + (Number1 - Number2));
                    break;
                case 3:
                    Console.WriteLine(Number1 + "*" + Number2 + "=" + (Number1 * Number2));
                    break;
                case 4:
                    Console.WriteLine(Number1 + "/" + Number2 + "=" + (Number1 / Number2));
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;
            }
        }
    }
}
