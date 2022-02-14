using IngresoSML2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IngresoSML2.Interfaces
{
    public interface IInvoiceItemsInterface
    {
        int AddInvoiceItems(IEnumerable<InvoiceItem> items);
    }
}
