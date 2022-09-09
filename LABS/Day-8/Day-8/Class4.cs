using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day_8
{
    //Regex
    class Class4
    {
        public static void Main()
        {
            Regex r = new Regex("^[0-9]{6}$");
            Regex r1 = new Regex("^[a-z]{6}$");
            Regex r2 = new Regex("^[A-Z]{6}$");
            if (r.IsMatch("123567"))
            {
                Console.WriteLine("Value Is correct");
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }
            
        }
    }
}
