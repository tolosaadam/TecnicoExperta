using AutoMapper;
using AutoMapper.QueryableExtensions;
using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using IngresoSML2.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IngresoSML2.Repositories
{
    public class CustomerRepository : ICustomerInterface
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<CustomerRepository> _logger;
        public CustomerRepository(AppDbContext context, IMapper mapper, ILogger<CustomerRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<CustomerDTO> GetAllCustomers()
        {
            try
            {
                var Customers = _context.Customers.ProjectTo<CustomerDTO>(_mapper.ConfigurationProvider).ToList();

                return Customers;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"GetAllCustomers TO 'DATABASE'  ERROR = {ex} ");
                throw new Exception(ex.Message);
            }
        }
    }
}
