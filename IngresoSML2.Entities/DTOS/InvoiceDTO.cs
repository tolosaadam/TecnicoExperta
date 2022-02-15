using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IngresoSML2.Entities.DTOS
{
    public class InvoiceDTO
    {

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }

        public List<Code> Codes { get; set; }
        public string Product { get; set; }

    }

    public class Code
    {
        public string Product { get; set; } 
    }

}