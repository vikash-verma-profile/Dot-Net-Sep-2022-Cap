using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    /// <summary>
    /// Structures and enums
    /// </summary>
    /// Structures vs classes

    public struct EmployeeM
    {
        private int employeeId;
        private string employeeName;
        public string address;

        public void GetData()
        {
            Console.WriteLine("Please enter employee Name");
            employeeName = Console.ReadLine();
            Console.WriteLine("Please enter employee ID");
            employeeId = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Employee Details are :");
            Console.WriteLine("EmployeeID : {0} Employee Name {1} ", employeeId, employeeName);
        }
    };
    class Class4
    {
        public static void Main8()
        {

            EmployeeM e = new EmployeeM() ;
            e.address = "Hi";
            e.GetData();
            e.Print();
        }
    }
}
