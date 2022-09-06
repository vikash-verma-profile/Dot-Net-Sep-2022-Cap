using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    /// <summary>
    /// operator overloading
    /// </summary>
    class Calculator
    {
        int Number1, Number2;
        public Calculator(int num1,int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }
        public void Print()
        {
            Console.WriteLine("Number 1="+Number1);
            Console.WriteLine("Number 2=" + Number2);
        }
        public static Calculator operator +(Calculator c1,Calculator c2)
        {
            Calculator c3 = new Calculator(0, 0);
            c3.Number1 = c1.Number1 + c2.Number1;
            c3.Number2 = c1.Number2 + c2.Number2;
            return c3;
        }
    }
    class Class6
    {
        public static void Main()
        {
            Calculator c1 = new Calculator(10, 20);
            Calculator c2 = new Calculator(20, 20);
            Calculator c3 = new Calculator(0, 0);
            c3 = c1 + c2;
            c3.Print();
        }
    }
}
