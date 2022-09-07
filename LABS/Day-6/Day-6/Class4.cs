using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    /// <summary>
    /// equal vs ==
    /// </summary>
    class Class4
    {
        public static void Main()
        {
            string s = "vikash";
            char[] s1 = { 'v', 'i', 'k', 'a', 's', 'h' };
            string s2 = new string(s1);
            Console.WriteLine(s==s2);
            Console.WriteLine(s.Equals(s2));


            string s3 = s;
            Console.WriteLine(s3 == s2);
            Console.WriteLine(s3.Equals(s2));

        }
    }
}
