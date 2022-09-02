using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class2
    {
        /*
         * <return-type> nameoffunction (number of aruguments)
         */
        public static void Main3()
        {
            Sum(1,2);
            int result=ADD(3, 4);
            Console.WriteLine(result);
        }

        public static void Sum(int a,int b)
        {
           // int a, b;
           // a = 1; b = 3;
            Console.WriteLine(a + b);
        }
        public static int ADD(int a, int b)
        {
            return (a + b);
        }
    }
}
