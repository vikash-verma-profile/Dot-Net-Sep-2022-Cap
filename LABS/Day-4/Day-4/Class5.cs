using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// Constructors
    /// </summary>
    /// 

    /* Default
     * parametized
     * private constructor
     * static constructor
     * copy constructor
     */
    class Sample
    {
        //<access-specifier> class name (<parameters>)
        int a, b;
        public Sample(int x,int y)
        {
            a = x;
            b = y;
        }
        public void print()
        {
            Console.WriteLine("Value are a = {0} and b={1}",a,b);
        }
        ~Sample()
        {
          
        }
    }
    class Class5
    {
        public static void Main6()
        {
            Sample s = new Sample(1,2);
            s.print();

        }
    }
}
