using ConnectWithDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConnectWithDB
{
    class Class6
    {
        public static void Main()
        {
            TestDBContext db = new TestDBContext();
            var data = db.TblEmployees.Join(
                db.TblDepartments,x=>x.DepartmentId,y=>y.Id,
                (x,y)=>new { Id=x.Id,EmployeeName=x.EmployeeName,EmployeeSalary=x.EmployeeSalary,DepartmentName=y.DepartmentName});

            Console.WriteLine("ID | EmployeeName | EmployeeSalary | DepartmentName");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id+" "+item.EmployeeName + " " + item.EmployeeSalary + " " + item.DepartmentName);
            }
        }
    }
}
