using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    /// <summary>
    /// ARRAYS
    /// </summary>
    class Class9
    {
        public static void Main()
        {
            //int[] sampleaaray = new int[3] { 1, 2, 3 };
            //Console.WriteLine(sampleaaray[0]);
            //Console.WriteLine(sampleaaray[1]);
            //Console.WriteLine(sampleaaray[2]);
            int[] sampleaaray = new int[3];
            for (int i = 0; i < sampleaaray.Length; i++)
            {
                Console.WriteLine("Please enter the value for sampleaaray[" + i+"]= ");
                sampleaaray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sampleaaray.Length; i++)
            {
                Console.Write("the value of sampleaaray[" + i + "]= ");
                Console.WriteLine(sampleaaray[i]);
            }

            //loops
            /* for loop
             * while loop
             * do while 
             * foreach
             */

            Console.WriteLine("===============For Loop==========");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("===============WHile Loop==========");
            //entry controlled loop
            int j = 0;
            while (j<3)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("===============Do WHile Loop==========");

            //Exit controlled loop
            j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j<3);
        }
    }
}
