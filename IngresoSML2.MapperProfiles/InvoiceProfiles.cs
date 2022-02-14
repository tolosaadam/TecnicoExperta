﻿using AutoMapper;
using IngresoSML2.Entities;
using IngresoSML2.Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IngresoSML2.MapperProfiles
{
    public class InvoiceProfiles : Profile
    {
        public InvoiceProfiles()
        {
            CreateMap<Invoice, InvoiceDTO>();
            CreateMap<InvoiceDTO, Invoice>();
        }      
    }   
}
