using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqQueries
{
    //ofType
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }
    class Class1
    {
        public static void Main()
        {

            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("Two");
            mixedList.Add("Three");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID=1,StudentName="Vikash"});

            var stringResult = from s in mixedList.OfType<string>() select s;
            var stringResult1 = mixedList.OfType<string>();

            Console.WriteLine("=======OfType=========");
            Console.WriteLine("Linq ");
            foreach (var item in stringResult)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Linq to entity");
            foreach (var item in stringResult1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
