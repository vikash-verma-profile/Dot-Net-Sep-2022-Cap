using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    /// <summary>
    /// Convert VS Int.parse and Int.Tryparse
    /// </summary>
    class Class5
    {
        public static void Main()
        {
            string s = "123";
            int Number2 = 4;
            //int result = int.Parse(s);
            int result;
           bool flag= int.TryParse(s,out result);//output from a function
            if (flag == true)
            {
                Console.WriteLine("I am able to convert the value");
            }
            else
            {
                Console.WriteLine("I am  not able to parse the value");
            }
            int sum = result + Number2;
            Console.WriteLine(result);
        }
    }
}
