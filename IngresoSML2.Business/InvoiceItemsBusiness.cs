using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using IngresoSML2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IngresoSML2.Business
{
    public class InvoiceItemsBusiness
    {
        public InvoiceItemsBusiness(IInvoiceItemsInterface repository)
        {
            _repository = repository;

        }
        private readonly IInvoiceItemsInterface _repository;


        /// <summary>  
        /// Este metodo agrega dentro de la base de datos los InvoiceItems correspondientes al ID del Invoice.  
        /// </summary>  
        /// <param id="1"></param>  
        /// <param iDTO="Invoice Data Transfer Object"></param> 
        /// <remarks>
        /// Retorna un ResponseDTO al InvoiceBusiness para luego enviarlo al controller con información sobre si la creación del Invoice e InvoiceItems fue correcta o fallo.
        /// </remarks>
        /// <returns>ResponseDTO</returns>
        public ResponseDTO CreateInvoiceItems(int id, InvoiceDTO iDTO)
        {
            List<InvoiceItem> items = new List<InvoiceItem>();

            foreach (Code item in iDTO.Codes)
            {
                InvoiceItem it = new InvoiceItem()
                {
                    InvoiceId = id,
                    ProductCode = item.Product
                };
                items.Add(it);
            }

            var responseNumber = _repository.AddInvoiceItems(items);

            ResponseDTO response = new ResponseDTO();
            if (responseNumber == 1)
            {
                response.Message = "Success Add";
                response.IsError = false;               
            }
            else
            {
                response.Message = "Failed Add";
                response.IsError = true;
            }

            return response;
        }
    }
}
