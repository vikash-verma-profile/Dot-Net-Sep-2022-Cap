using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    //ref vs out
    //var vs dynamic
    class Class6
    {
        public static void Main()
        {
            var i = 1;//integer type
                      //Compile time variable
                      //  i = "Vikash";//string type

            Type type = i.GetType();
            Console.WriteLine(i);
            Console.WriteLine(type);

            Console.WriteLine("=============================");
            //run time
            //it have automatic type casting internally
            dynamic j = 1;
            Type typed = j.GetType();
            Console.WriteLine(j);
            Console.WriteLine(typed);
            j = "Vikash";
            typed= j.GetType();
            Console.WriteLine(j);
            Console.WriteLine(typed);

        }
    }
}
