using IngresoSML2.Entities;
using System;
using System.Collections.Generic;

namespace IngresoSML2.Interfaces
{
    public interface InvoiceInterface
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}
