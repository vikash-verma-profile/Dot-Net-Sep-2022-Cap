using System;

namespace Day_4
{
    /// <summary>
    /// 
    /// 2d array
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];// { { 1, 2 },{ 3, 4 } };
             //Input from a 2d array
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Please enter value for matrix["+row+","+col+"] :");
                    matrix[row, col]=Convert.ToInt32(Console.ReadLine());
                }
            }

            //print a 2d array
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
