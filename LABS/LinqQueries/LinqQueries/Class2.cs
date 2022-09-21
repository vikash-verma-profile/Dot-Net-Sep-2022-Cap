using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqQueries
{
    class Class2
    {
        public static void Main()
        {
            IList<Student> studentList = new List<Student>() {

                new Student(){StudentID=1,StudentName="john",StudentAge=15},
                  new Student(){StudentID=2,StudentName="Steve",StudentAge=15},
                    new Student(){StudentID=3,StudentName="Bill",StudentAge=25},
                     new Student(){StudentID=4,StudentName="Ram",StudentAge=20},
                      new Student(){StudentID=5,StudentName="Ron",StudentAge=19}
            };

            var groupResult = from s in studentList group s by s.StudentAge;
            var groupResult1 = studentList.GroupBy(x => x.StudentAge);
            Console.WriteLine("=====");
            foreach (var item in groupResult)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("=====");
            foreach (var item in groupResult1)
            {
                Console.WriteLine(item.Key);

            }
            //Contains
            var sample = studentList.Select(x => x.StudentName.Contains("Vikash"));
            foreach (var item in sample)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("-========================");
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(10);
            Console.WriteLine(result);

            Console.WriteLine("-==============Aggregate==========");
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four" };
            var commasepatedstring = strList.Aggregate((s1,s2)=>s1+","+s2);
            Console.WriteLine(commasepatedstring);
        }
    }
}
