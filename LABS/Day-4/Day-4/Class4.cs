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

        public int a,b;
    }
    class Class4
    {
        public static void Main()
        {
            //<class Name> objectname =new //();
            Student obj = new Student();
            obj.a = 10;
            obj.b = 20;
            Console.WriteLine(obj.a + obj.b);
        }
    }
}
