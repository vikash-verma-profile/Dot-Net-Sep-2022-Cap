using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerLogin.Models
{
    public partial class TblLogin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? IsActive { get; set; }
    }
}
