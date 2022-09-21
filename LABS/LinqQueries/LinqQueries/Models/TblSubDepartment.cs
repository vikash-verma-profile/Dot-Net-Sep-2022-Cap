using System;
using System.Collections.Generic;

#nullable disable

namespace LinqQueries.Models
{
    public partial class TblSubDepartment
    {
        public int Id { get; set; }
        public string SubDepartmentName { get; set; }
        public int? DepartmentId { get; set; }
    }
}
