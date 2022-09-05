using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Class3
    {
        public static void Main4()
        {
            string s = "Vikash";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            string s1=string.Concat(s, " ", "Verma");
            string newstring = "Hi I am here";
            string q=newstring.Replace("Hi","Hello");

            
            Console.WriteLine("Old string is "+newstring);
            Console.WriteLine("After repacement new string is "+q);
        }
    }
}
