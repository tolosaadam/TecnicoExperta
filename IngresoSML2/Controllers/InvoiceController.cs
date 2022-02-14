using IngresoSML2.Data;
using IngresoSML2.Models;
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
        private readonly AppDbContext dbContext;

        public InvoiceController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] InvoicePostModel pm)
        {
            // TODO
            return Ok("OK");
        }

        //[HttpGet]
        //public IActionResult GetMultas()
        //{
        //    _logger.LogInformation("GetAllMultas  From Controller");
        //    return Ok(_business.GetLists());
        //}




    }
}
