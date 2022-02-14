
using IngresoSML2.Business;
using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngresoSML2.Controllers
{
    [Route("/api/invoice")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly InvoiceBusiness _business;

        public InvoiceController(InvoiceBusiness business)
        {
            _business = business;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] InvoiceDTO pm)
        {
            // TODO
            return Ok(_business.GetAllCustomers());
        }

        //[HttpGet]
        //public IActionResult GetMultas()
        //{
        //    _logger.LogInformation("GetAllMultas  From Controller");
        //    return Ok(_business.GetLists());
        //}




    }
}
