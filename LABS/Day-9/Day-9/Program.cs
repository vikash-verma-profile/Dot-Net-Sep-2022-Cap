using System;
using System.IO;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Writing into a file
            FileStream fs = new FileStream("sample.txt",FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string str = "Vikash Verma";
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();


            //Reading from a file
            FileStream fsR = new FileStream("sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsR);
            Console.WriteLine("======Content from file========");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while(str!=null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fsR.Close();
        }
    }
}
