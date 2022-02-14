using AutoMapper;
using IngresoSML2.Entities;
using IngresoSML2.Interfaces;
using System;
using System.Collections.Generic;

namespace IngresoSML2.Business
{
    public class InvoiceBusiness
    {

        public InvoiceBusiness(InvoiceInterface repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        private readonly InvoiceInterface _repository;
        private readonly IMapper _mapper;

        /// <summary>  
        /// Este metodo ingresa la multa y todas sus propiedades dentro de la base de datos.  
        /// </summary>  
        /// <param matricula="KKL003"></param>  
        /// <param sensorDTO="Velocidad, Altura, Localizacion X, Localizacion Y"></param> 
        /// <returns>Retorna si la multa es valida, la Ciudad asignada y la distancia hasta ella</returns>
        public IEnumerable<Customer> GetAllCustomers()
        {

            //var multaDTO = _mapper.Map<SensorDTO, MultaDTO>(sensorDTO);
            //var closestCity = GetClosestCity(new LocalizacionDTO { X = sensorDTO.X, Y = sensorDTO.Y });
            //multaDTO.Ciudad = closestCity.Nombre;
            //multaDTO.DistanceToCity = closestCity.Distancia;
            //multaDTO.MatriculaId = matricula;

            //var multa = _mapper.Map<MultaDTO, Multa>(multaDTO);

            var response = _repository.GetAllCustomers();

            return response;
        }
    }
}
