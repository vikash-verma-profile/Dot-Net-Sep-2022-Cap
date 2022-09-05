using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// Interfaces
    /// </summary>
    /// 
    interface IA
    {
        void show();
    }
    class DUmmyB:IA
    {
        public void show()
        {
            Console.WriteLine("Hi");
        }
    }
    interface AA
    {
        void print();
    }
    interface BB
    {
        void show();

    }
    class CC : AA, BB
    {
        public void print()
        {
            Console.WriteLine("Hi I am from IA");
        }

        public void show()
        {
            Console.WriteLine("Hi I am from IB");
        }
    }
    class Class9
    {
        public static void Main()
        {
            DUmmyB b = new DUmmyB();
            b.show();
            CC c = new CC();
            c.print();
            c.show();
        }
    }
}
