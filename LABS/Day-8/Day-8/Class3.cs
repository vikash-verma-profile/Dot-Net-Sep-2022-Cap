using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
        public int EmployeeSalary { get; set; }
    }
    class Class3
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the choice you want to do \n 1.ADD \n 2.Delete");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                default:
                    break;
            }
            List<Employee> el = new List<Employee>();
        }
        
    }
}
