using AutoMapper;
using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using IngresoSML2.Interfaces;
using System;
using System.Collections.Generic;

namespace IngresoSML2.Business
{
    public class InvoiceBusiness
    {

        public InvoiceBusiness(IInvoiceInterface repository, InvoiceItemsBusiness business, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _business = business;
        }
        private readonly IInvoiceInterface _repository;
        private readonly IMapper _mapper;
        private readonly InvoiceItemsBusiness _business;

        /// <summary>  
        /// Este metodo hace el manejo del Invoice tanto la respuesta al front, como la creación de Invoice e InvoiceItems.  
        /// </summary>
        /// <param iDTO="Invoice Data Transfer Object"></param> 
        /// <remarks>
        /// Retorna un ResponseDTO al controller con información sobre si la creación del Invoice e InvoiceItems fue correcta o fallo.
        /// </remarks>
        /// <returns>ResponseDTO</returns>
        public ResponseDTO ManageInvoice(InvoiceDTO iDTO)
        {
            var invoiceId = CreateInvoice(iDTO);
            var response = _business.CreateInvoiceItems(invoiceId, iDTO);
            return response;

        }

        /// <summary>  
        /// Este metodo agrega dentro de la base de datos el invoice.  
        /// </summary>  
        /// <param iDTO="Invoice Data Transfer Object"></param> 
        /// <remarks>
        /// Retorna el id del Invoice auto-generado luego de agregarlo dentro de la base de datos para paserselo a los InvoiceItems.
        /// </remarks>
        /// <returns>int</returns>
        public int CreateInvoice(InvoiceDTO iDTO)
        {
            var invoice = _mapper.Map<InvoiceDTO, Invoice>(iDTO);
            var invoiceId = _repository.AddInvoice(invoice);
            return invoiceId;
            
        }     
    }   
}
