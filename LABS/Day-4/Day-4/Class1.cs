using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    //transpose
    class Class1
    {
        public static void Main2()
        {
            int[,] matrix = new int[2, 2];// { { 1, 2 },{ 3, 4 } };
                                          //Input from a 2d array

            int[,] Tmatrix = new int[2, 2];
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Please enter value for matrix[" + row + "," + col + "] :");
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Process Loop
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Tmatrix[row, col] = matrix[col, row];
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
            Console.WriteLine("Matrix after Transpose");
            //print after Transpose
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(Tmatrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
