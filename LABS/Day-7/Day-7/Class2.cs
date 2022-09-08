using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    /// <summary>
    /// Constructors
    /// 1.Default constructor
    /// 2.parameterized constructor
    /// 3.Static Constructor
    /// 4.Copy COnstructor
    /// 5.private constructor
    /// </summary>
    /// 
    class Aa
    {
        private Aa()
        {
            //if we have private constructor then we cannot create an object
            //and we cannot extend that class also

            //when you want to create an object to have only one instance throughout
            //the application at that time we use private constructors
        }
    }
    class Class2
    {
        public static void Main3()
        {
            //Aa a = new Aa();
        }
    }
}
