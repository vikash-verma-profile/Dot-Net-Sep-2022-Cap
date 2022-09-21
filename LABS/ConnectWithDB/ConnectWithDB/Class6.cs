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
            //var data = db.TblEmployees.Join(
            //    db.TblDepartments,x=>x.DepartmentId,y=>y.Id,
            //    (x,y)=>new { Id=x.Id,EmployeeName=x.EmployeeName,EmployeeSalary=x.EmployeeSalary,DepartmentName=y.DepartmentName});

            var data = db.TblEmployees.Join(
                db.TblDepartments, x => x.DepartmentId, y => y.Id,
                (x, y) =>new { x,y}).Join(db.TblSubDepartments,z=>z.y.Id,s=>s.DepartmentId,(z,s)=>
                new {id= z.x.Id, EmployeeName =z.x.EmployeeName, 
                    EmployeeSalary =z.x.EmployeeSalary, DepartmentName=z.y.DepartmentName,SubDepartment=s.SubDepartmentName});
            Console.WriteLine("ID | EmployeeName | EmployeeSalary | DepartmentName  | SubDepartmentName");
            foreach (var item in data)
            {
                Console.WriteLine(item.id+" "+item.EmployeeName + " " + item.EmployeeSalary + " " + item.DepartmentName+" "+item.SubDepartment);
            }
        }
    }
}
