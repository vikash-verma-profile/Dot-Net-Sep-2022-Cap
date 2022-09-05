using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// jagged array's
    /// </summary>
    class Class2
    {
        public static void Main3()
        {
            int[][] jagged = new int[4][];
            int []array1 =new int[]{ 1,2,3};
            int[] array2 = new int[] { 1, 2, 3 ,4};
            int[] array3 = new int[] { 1, 2, 3, 4,5 };
            int[] array4 = new int[] { 1, 2, 3, 4, 5, 6 };

            jagged[0] = array1;
            jagged[1] = array2;
            jagged[2] = array3;
            jagged[3] = array4;

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine("=========ARRAY"+i+"===============");
                for (int k = 0; k < jagged[i].Length; k++)
                {
                    Console.Write(jagged[i][k]);
                }
                Console.WriteLine();
            }
        }
    }
}
