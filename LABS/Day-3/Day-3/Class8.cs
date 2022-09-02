using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    /// <summary>
    /// Type of parameters
    /// 
    /// Input
    /// Output
    /// Named
    /// Optional 
    /// 
    /// </summary>
    class Class8
    {
        public static void Main9()
        {
            SumIN(1, 2);
            int result;
            SumOut(1, 2,out result);
            Console.WriteLine("Output from output parameter "+result);
            SumNamed(b:1, c:2, a:3);
            SumOptional(10,10);
        }
        public static void SumIN(in int a,in int b)//input parameters
        {
            Console.WriteLine(a + b);
        }
        public static void SumOut(int a,int b,out int c)
        {
            c = a + b;
        }

        public static void SumNamed(int a,int b,int c)
        {
            Console.WriteLine("sum from Named parameters"+(a+b+c));
            Console.WriteLine("b= " + b);
            Console.WriteLine("c= " + c);
        }

        public static void SumOptional(int a,int b=10,int c=20)
        {
            Console.WriteLine("The optional output is "+(a+b+c));
        }
    }
}
