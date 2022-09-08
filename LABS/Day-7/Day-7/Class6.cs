using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    //indexers and properties

    class PA
    {
        int a;

        public int A { get { return a; } set { a = value; } }
        //public int get()
        //{
        //    return a;
        //}

        //public void set(int _a)
        //{
        //    a = _a;
        //}
    }
    class Class6
    {
        public static void Main()
        {
            PA a = new PA();
            a.A = 1;
            Console.WriteLine(a.A);
        }
    }
}
