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

            IList<Student> studentList = new List<Student>() { 
            
                new Student(){StudentID=1,StudentName="john",StudentAge=18},
                  new Student(){StudentID=2,StudentName="Steve",StudentAge=15},
                    new Student(){StudentID=3,StudentName="Bill",StudentAge=25},
                     new Student(){StudentID=4,StudentName="Ram",StudentAge=20},
                      new Student(){StudentID=5,StudentName="Ron",StudentAge=19}
            };

            var orderbyRasult = from s in studentList orderby s.StudentName select s;
            var orderbyResult2 = studentList.OrderBy(x => x.StudentName);

            Console.WriteLine("============Order by=======");
            foreach (var item in orderbyRasult)
            {
                Console.WriteLine(item.StudentName);
            }
            foreach (var item in orderbyResult2)
            {
                Console.WriteLine(item.StudentName);
            }

            var orderbyRasultDesc = from s in studentList orderby s.StudentName descending select s;
            var orderbyResultDesc2 = studentList.OrderByDescending(x => x.StudentName);

        }
    }
}
