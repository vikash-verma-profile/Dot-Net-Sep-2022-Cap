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
        [HttpGet]
        public IEnumerable<TblCustomer> get()
        {
            return db.TblCustomers;
        }
        [HttpPost]
        public IActionResult post(TblCustomer customer)
        {
            db.TblCustomers.Add(customer);
            db.SaveChanges();
            return Ok(new { ststus = "your record is added suceessfully" });
        }
    }
}
