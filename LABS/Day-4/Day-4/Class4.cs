using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Student
    {
        //members or fields
        //methods
        //constrtuctors and destructors
        //properties
        //indexers

        //access-specifiers
        //1.public
        //2.protected
        //3.internal
        //4.private
        //5.private protected
        //6.internal protected

        int RollNO;
        string StudentName;
        public void GetData()
        {
            Console.WriteLine("Please enter the student roll ");
            RollNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Student Name");
            StudentName = Console.ReadLine();
        }
        public void PrintData()
        {
            Console.WriteLine("Student Details are:");
            Console.WriteLine("Student RollNo : " + RollNO);
            Console.WriteLine("Student Name : " + StudentName);
        }
    }
    class Class4
    {
        public static void Main5()
        {
            //<class Name> objectname =new //();
            Student student = new Student();
            student.GetData();
            student.PrintData();
        }
    }
}
