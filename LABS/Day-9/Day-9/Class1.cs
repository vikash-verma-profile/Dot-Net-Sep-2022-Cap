using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9
{
    class student
    {
        public student()
        {
            ID = 101;
            StudentName = "Vikash Verma";
        }
        public int ID { get; set; }
        public string StudentName { get; set; }

        public void WriteInFile()
        {

        }
    }
    class Class1
    {
        public static void Main()
        {
            //c# code to json format
            student student = new student();

            //convert to json
            var json = JsonConvert.SerializeObject(student);
            Console.WriteLine(json);

            //json to object
            var studentObj = JsonConvert.DeserializeObject<student>(json);


        }
    }
}
