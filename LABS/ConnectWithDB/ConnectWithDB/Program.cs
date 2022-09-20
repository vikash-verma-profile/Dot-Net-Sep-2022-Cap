using ConnectWithDB.Models;
using System;
using System.Linq;

namespace ConnectWithDB
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Create db context object
            TestDBContext db = new TestDBContext();
            //use object to connect with db tables
            //var data = db.TblSamples;
            //Console.WriteLine("ID | TEXT");
            ////iteration on db data
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Id+"   "+item.Text);
            //}

            TblSample obj = new TblSample();
            obj.Text = "Vikash";

            db.TblSamples.Add(obj);
            db.SaveChanges();
            Console.WriteLine("Record is added");

            //Console.WriteLine("Please enter Id to update");
            //int id=Convert.ToInt32(Console.ReadLine());
            //var data=TblSample.
        }
    }
}
