using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    //Custom exceptions

    class Myexception : Exception
    {
        public Myexception(String Message):base(Message)
        {

        }
    }
    class Class1
    {
        static void Validate(int age)
        {
            if (age < 18)
            {
                //when we want we can raise exception by using throw
                throw new Myexception("Please enter age greater than 18");
            }
        }
        public static void Main()
        {
            try{
                Validate(12);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
