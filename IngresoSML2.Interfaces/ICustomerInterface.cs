using IngresoSML2.Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace IngresoSML2.Interfaces
{
    public interface ICustomerInterface
    {
        IEnumerable<CustomerDTO> GetAllCustomers();
    }
}
