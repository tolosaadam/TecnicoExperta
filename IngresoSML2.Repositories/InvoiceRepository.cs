using AutoMapper;
using AutoMapper.QueryableExtensions;
using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using IngresoSML2.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IngresoSML2.Repositories
{
    public class InvoiceRepository: IInvoiceInterface
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<InvoiceRepository> _logger;
        public InvoiceRepository(AppDbContext context, IMapper mapper, ILogger<InvoiceRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public int AddInvoice(Invoice invoice)
        {
           
            try
            {
                _context.Invoices.Add(invoice);
                _context.SaveChanges();
                return invoice.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError($"AddInvoice TO 'DATABASE' ERROR = {ex} ");
                throw new Exception(ex.Message);
            }
        }
    }
}
