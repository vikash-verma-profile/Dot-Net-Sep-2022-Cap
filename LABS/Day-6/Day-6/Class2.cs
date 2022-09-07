using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    //static keyword
    //boxing and unboxing
    //Nullable Type
    //is vs as 
    //is ==> if/else
    //as ==> conversions
    class Class2
    {
        public static void Main3()
        {
            //Boxing
            int i=1;
            object o;
            o = i;
            Console.WriteLine(o);

            //UnBoxing
            i = (int)o;
            Console.WriteLine(i);

            //null
            Nullable<int> c = null;
            int ?d = null;
            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}
