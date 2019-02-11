using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiciosWeb.Datos.Modelo;
using ServiciosWeb.WebApi.Models;
using AutoMapper;

namespace ServiciosWeb.WebApi.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ServiciosWeb.Datos.Modelo.Order, ServiciosWeb.WebApi.Models.Order>()
                    .ForMember(dest => dest.orderDate,
                                opt => opt.MapFrom(src => src.OrderDate))
                    .ForMember(dest => dest.requiredDate,
                                opt => opt.MapFrom(src => src.RequiredDate))
                    .ForMember(dest => dest.shippedDate,
                                opt => opt.MapFrom(src => src.ShippedDate))
                    .ForMember(dest => dest.freight,
                                opt => opt.MapFrom(src => src.Freight));
            });
        }
    }
}