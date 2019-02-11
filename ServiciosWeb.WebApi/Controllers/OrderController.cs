using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiciosWeb.Datos.Modelo;

namespace ServiciosWeb.WebApi.Controllers
{
    public class OrderController : ApiController
    {
        NorthwindConection BD = new NorthwindConection();
        
        /// <summary>
        /// Permite consultar la información de todas las órdenes.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Orders> Get()
        {
            var orders = BD.Orders.ToList();

            return orders;
        }
    }
}
