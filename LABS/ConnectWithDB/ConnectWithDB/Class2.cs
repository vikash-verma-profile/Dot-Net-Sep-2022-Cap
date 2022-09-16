using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PersonApp1
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }


    class PersonImplementation
    {
        public void GetName(IList<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} - {person.Address}");
            }
        }


        public double Average(IList<Person> person)
        {
            return person.Average(p => p.Age);
        }


        public int Max(IList<Person> person)
        {
            return person.Max(p => p.Age);
        }
    }


    class class1
    {
        public static void Main()
        {

            PersonImplementation s = new PersonImplementation();

            IList<Person> p = new List<Person>();

            p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
            Console.WriteLine(s.Average(p));
            Console.WriteLine(s.Max(p));
        }
    }

}