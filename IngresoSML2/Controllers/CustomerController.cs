using IngresoSML2.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngresoSML2.Controllers
{
    [Route("/api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerBusiness _business;

        public CustomerController(CustomerBusiness business)
        {
            _business = business;
        }


        [HttpGet]
        public IActionResult GetCustomer()
        {
            return Ok(_business.GetAllCustomers());
        }
    }
}
