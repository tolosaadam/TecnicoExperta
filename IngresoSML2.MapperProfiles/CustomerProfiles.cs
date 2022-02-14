using AutoMapper;
using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace IngresoSML2.MapperProfiles
{
    public class CustomerProfiles : Profile
    {
        public CustomerProfiles()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
        }      
    }
}
