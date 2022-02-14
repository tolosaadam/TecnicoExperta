using IngresoSML2.Entities;
using IngresoSML2.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace IngresoSML2.Repositories
{
    public class InvoiceItemsRepository : IInvoiceItemsInterface
    {
        private readonly AppDbContext _context;
        private readonly ILogger<InvoiceItemsRepository> _logger;
        public InvoiceItemsRepository(AppDbContext context, ILogger<InvoiceItemsRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public int AddInvoiceItems(IEnumerable<InvoiceItem> items)
        {

            try
            {
                foreach (InvoiceItem item in items)
                {

                    _context.InvoiceItems.Add(item);
                }
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"AddInvoiceItems TO 'DATABASE'  ERROR = {ex} ");
                throw new Exception(ex.Message);
            }
        }
    }
}
