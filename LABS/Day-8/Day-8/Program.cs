using System;

namespace Day_8
{
    //Exceptional Handling
    //try
    /*
     * Catch
     * finally
     * throw
     */


    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 0;
            int c;
            int[] a1 = new int[3];
            try
            {
               //c= a / b;
               c = 89;
               //a1[3] = 90;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Some error Occured");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Some error Occured in array");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Hi I am coming from finally block");
            }
           
            //Console.WriteLine("Hello World!");
        }
    }
}
