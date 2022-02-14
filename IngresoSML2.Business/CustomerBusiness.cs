using IngresoSML2.Entities.DTOS;
using IngresoSML2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IngresoSML2.Business
{
    public class CustomerBusiness
    {
        public CustomerBusiness(ICustomerInterface repository)
        {
            _repository = repository;
        }
        private readonly ICustomerInterface _repository;


        /// <summary>  
        /// Este metodo consulta todos los Customer dentro de la base de datos.  
        /// </summary>
        /// <returns> IEnumerable de CustomerDTO </returns>
        public IEnumerable<CustomerDTO> GetAllCustomers()
        {
            var response = _repository.GetAllCustomers();
            return response;
        }
    }
}
