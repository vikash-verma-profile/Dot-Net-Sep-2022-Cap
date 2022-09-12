using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9
{
    /// <summary>
    /// Delegates
    /// </summary>
    class Class2
    {
        public delegate void addNum(int a,int b);

        public void sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void subtract(int a,int b)
        {
            Console.WriteLine(a-b);
        }
        public static void Main()
        {
            Class2 c = new Class2();
            addNum addNumDel = new addNum(c.sum);
            addNumDel(100,40);

            addNum addNumDel2 = new addNum(c.subtract);
            addNumDel2(100, 40);
        }
    }
}
