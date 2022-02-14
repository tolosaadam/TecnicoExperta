using IngresoSML2.Entities;
using IngresoSML2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IngresoSML2.Repositories
{
    public class InvoiceRepository: InvoiceInterface
    {
        private readonly AppDbContext _context;
        //private readonly ILogger<SensorRepository> _logger;
        public InvoiceRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            try
            {
                var Customers = _context.Customers;

                return Customers;
            }
            catch (Exception ex)
            {
                //_logger.LogInformation($"GetAllMultas TO 'DATABASE'  ERROR = {ex} ");
                throw new Exception(ex.Message);
            }
        }

    }
}
