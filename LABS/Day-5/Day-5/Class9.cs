using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    /// <summary>
    /// operator overloading
    /// </summary>
    class CalculatorM
    {
        int Number1, Number2;
        public CalculatorM(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }
        public void Print()
        {
            Console.WriteLine("Number 1=" + Number1);
            Console.WriteLine("Number 2=" + Number2);
        }
        public static CalculatorM operator *(CalculatorM c1, CalculatorM c2)
        {
            CalculatorM c3 = new CalculatorM(0, 0);
            c3.Number1 = c1.Number1 *c2.Number1;
            c3.Number2 = c1.Number2 *c2.Number2;
            return c3;
        }
    }
    class Class9
    {
        public static void Main()
        {
            CalculatorM c1 = new CalculatorM(10, 20);
            CalculatorM c2 = new CalculatorM(20, 20);
            CalculatorM c3 = new CalculatorM(0, 0);
            c3 = c1 * c2;
            c3.Print();
        }
    }
}
