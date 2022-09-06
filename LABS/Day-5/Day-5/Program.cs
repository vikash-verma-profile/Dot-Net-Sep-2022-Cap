using System;

namespace Day_5
{
    /// <summary>
    /// jagged array's
    /// array of array's
    /// </summary>
    class Program
    {
        static void Main1(string[] args)
        {
            //[] 1d
            //[,] 2d
            //[][]=>jagged array

            int[][] samplearray = new int[][] 
            {
                new int[]{1,2,3},
                new int[]{1,2,3,4},
                new int[]{ 1,2,3,4,5}
            };

            int[][] jagged = new int[4][];
            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 1, 2, 3,4 };
            jagged[2] = new int[] { 1, 2, 3,4,5 };
            jagged[3] = new int[] { 1, 2, 3 ,4,5,6};

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int k = 0; k < jagged[i].Length; k++)
                {
                    Console.Write(jagged[i][k]);
                }
                Console.WriteLine();
            }
        }
    }
}
