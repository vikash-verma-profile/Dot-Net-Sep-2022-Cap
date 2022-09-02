using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    /// <summary>
    /// 
    /// ref vs out
    /// </summary>
    class Class7
    {
        //ref we have to assign some value to parameter before passing it to function
        public static void Main()
        {
            int a =1, b=4 ;
            Console.WriteLine(Sum(ref a, ref b));
            int result;
            SumOut(a,b,out result);
            Console.WriteLine(result);
        }
        //out parameter before leaving from the method the out parameter must be
        //assigned with some value


        public static int Sum(ref int a,ref int b) {
            return (a + b);
        }
        public static void SumOut(int a,int b,out int c)
        {

            c = a + b;
        }
    }
}
