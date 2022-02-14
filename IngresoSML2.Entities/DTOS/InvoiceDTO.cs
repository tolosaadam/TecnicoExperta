using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoSML2.Entities.DTOS
{
    public class InvoiceDTO
    {

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }

        public List<String> Codes { get; set; }


    }

}