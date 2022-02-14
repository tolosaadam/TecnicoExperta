using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using System;
using System.Collections.Generic;

namespace IngresoSML2.Interfaces
{
    public interface IInvoiceInterface
    {
        int AddInvoice(Invoice iDTO);
    }
}
