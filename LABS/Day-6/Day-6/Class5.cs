using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    /// <summary>
    /// string
    /// </summary>
    class Class5
    {
        public static void Main()
        {
            string s = "Vikash";
            s = "Raj";
            Console.WriteLine(s);
            StringBuilder s1 = new StringBuilder("Vikash");
            Console.WriteLine(s1);
            s1.Append(" Is a Good boy");
            Console.WriteLine(s1);
            s1.Clear();
            s1.Append("Hi I a new value");
            Console.WriteLine(s1);
        }
    }
}
