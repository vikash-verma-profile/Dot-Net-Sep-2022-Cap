using LinqQueries.Models;
using System;

namespace LinqQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDBContext db = new TestDBContext();
            foreach (var item in db.TblEmployees)
            {
                Console.WriteLine(item.EmployeeName);
            }
        }
    }
}
