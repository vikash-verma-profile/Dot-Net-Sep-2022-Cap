using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    //access modiiers 
    /// <summary>
    /// internal
    /// private
    /// protected
    /// public
    /// </summary>
    /// 

    class SampleA
    {
        protected int a;
    }
    class SampleB:SampleA
    {
        public void Display()
        {
            Console.WriteLine(a);
        }
    }
    class Class4
    {
        public static void Main5()
        {
            SampleA a = new SampleA();
            //a.a
        }
    }
}
