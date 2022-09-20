using ConnectWithDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConnectWithDB
{
    class Class3
    {
        public static void printData(List<TblSample> data)
        {
            Console.WriteLine("ID | TEXT");
            //iteration on db data
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + "   " + item.Text);
            }
        }
        public static void Main()
        {

            /*selection
             * insertion
             * updation
             * Deletion
             */
            TestDBContext db = new TestDBContext();
            var data= db.TblSamples;

            printData(data.ToList());
            Console.WriteLine("Please select any id to update the data");
            int id = Convert.ToInt32(Console.ReadLine());

            var UpdateData = db.TblSamples.Where(x=>x.Id==id).FirstOrDefault();
            Console.WriteLine("Please enter some text that you want to update");
            var input = Console.ReadLine();
            UpdateData.Text = input;

            db.TblSamples.Update(UpdateData);
            db.SaveChanges();
            Console.WriteLine("database record is updated succesully");
            printData(data.ToList());

            Console.WriteLine("Please select any id to delete the data");
            int id2 = Convert.ToInt32(Console.ReadLine());
            var deleteItem = db.TblSamples.Where(x=>x.Id==id2).FirstOrDefault();
            db.TblSamples.Remove(deleteItem);
            db.SaveChanges();
            Console.WriteLine("database record is deleted succesully");
            printData(data.ToList());

        }
    }
}
