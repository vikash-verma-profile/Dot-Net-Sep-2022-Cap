using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    //ENUMS

    enum Status
    {
        Active=2,
        Deactive=3,
        Suspended
    }
    class Class5
    {
        public static void Main()
        {
            Console.WriteLine(Status.Active);
            Console.WriteLine((int)Status.Active);
            Console.WriteLine(Status.Deactive);
            Console.WriteLine((int)Status.Deactive);
            Console.WriteLine(Status.Suspended);
            Console.WriteLine((int)Status.Suspended);
        }
    }
}
