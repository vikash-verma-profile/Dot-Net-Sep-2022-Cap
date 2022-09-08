using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    /// <summary>
    /// copy constructor
    /// </summary>
    /// 
    class SampleCopyConstructor
    {
        private string name;

        public SampleCopyConstructor(string name)
        {
            this.name = name;
        }
        //copy constructor
        public SampleCopyConstructor(SampleCopyConstructor s)
        {
            name = s.name;
        }
        public void print()
        {
            Console.WriteLine(name);
        }
    }
    class Class3
    {
        public static void Main()
        {
            SampleCopyConstructor s1 = new SampleCopyConstructor("Vikash Verma");
            SampleCopyConstructor s2 = new SampleCopyConstructor(s1);

            s2.print();
        }
    }
}
