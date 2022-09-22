using CustomerAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDb1Context db = new CustomerDb1Context();
        public IEnumerable<TblCustomer> get()
        {
            return db.TblCustomers;
        }
    }
}
