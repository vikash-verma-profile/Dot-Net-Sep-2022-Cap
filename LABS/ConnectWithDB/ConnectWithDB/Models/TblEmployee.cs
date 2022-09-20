using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectWithDB.Models
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public decimal? EmployeeSalary { get; set; }
        public int? DepartmentId { get; set; }
    }
}
