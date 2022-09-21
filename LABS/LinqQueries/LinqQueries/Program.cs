using LinqQueries.Models;
using System;

namespace LinqQueries
{

    //where
    //join

    //select

    //first and firstordefault
    //last and lastordefault
    //elementat and elementatDefault
    //single and singleordefault
    class Program
    {
        static void Main1(string[] args)
        {
            TestDBContext db = new TestDBContext();
            foreach (var item in db.TblEmployees)
            {
                Console.WriteLine(item.EmployeeName);
            }


        }
    }
}
