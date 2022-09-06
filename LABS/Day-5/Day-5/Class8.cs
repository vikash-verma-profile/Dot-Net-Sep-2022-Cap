using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    /// <summary>
    /// Sealed
    /// </summary>
    /// 
    /// abstarct vs sealed
    /// 1.we cannot create an object abstract class | we can craete an object of selaed
    /// 2.we can extend an class from abstract class| we cannot extend a class that is sealed
    /// 

   abstract class SampleS1
    {

    }
   sealed class SampleS
    {

    }
    class SampleC//:SampleS
    {

    }
    class Class8
    {
        public static void Main()
        {
            //SampleS1 s = new SampleS1();
        }
    }
}
