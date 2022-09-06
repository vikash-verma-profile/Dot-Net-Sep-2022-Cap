using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class Person
    {
        string Name;
        public Person(string name)
        {
            Name = name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
        public override string ToString()
        {
            return "Name of the person is "+Name;
        }
    }
    class Class3
    {
        public static void Main4()
        {
            Person[] people = new Person[2];
            Person p1 = new Person("Vikash verma");
            Person p2 = new Person("Suresh Kumar");
            people[0] = p1;
            people[1] = p2;

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].ToString());
            }

        }
    }
}
