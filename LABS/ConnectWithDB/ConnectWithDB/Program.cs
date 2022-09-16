using ConnectWithDB.Models;
using System;

namespace ConnectWithDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create db context object
            TestDBContext db = new TestDBContext();
            //use object to connect with db tables
            var data = db.TblSamples;
            Console.WriteLine("ID | TEXT");
            //iteration on db data
            foreach (var item in data)
            {
                Console.WriteLine(item.Id+"   "+item.Text);
            }
        }
    }
}
