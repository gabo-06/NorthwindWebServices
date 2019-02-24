using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiciosWeb.Datos.Modelo;
using ServiciosWeb.WebApi.Models;
using AutoMapper;

namespace ServiciosWeb.WebApi.Controllers
{
    public class OrderController : ApiController
    {
        NorthwindConection BD = new NorthwindConection();

        /// <summary>
        /// Permite consultar la información de todas las órdenes.
        /// </summary>
        /// <returns></returns>
        // [HttpGet]
        // public IEnumerable<ServiciosWeb.WebApi.Models.Order> Get()
        // {
        //     #region Variables
        //     IEnumerable<ServiciosWeb.Datos.Modelo.Order> ordersBusinessModel;
        //     IEnumerable<ServiciosWeb.WebApi.Models.Order> ordersViewModel;
        //     #endregion
        // 
        //     try
        //     {
        //         #region Consulta el modelo y retorna la data.
        //         ordersBusinessModel = BD.Orders.Take(10).ToList();
        //         ordersViewModel = Mapper.Map<IEnumerable<ServiciosWeb.Datos.Modelo.Order>,
        //                                      IEnumerable<ServiciosWeb.WebApi.Models.Order>>(ordersBusinessModel);
        //         return ordersViewModel;
        //         #endregion
        //     }
        //     catch (Exception ex)
        //     {
        //         throw ex;
        //     }
        // }

        public IEnumerable<ServiciosWeb.Datos.Modelo.Order> Get()
        {
            var listado = BD.Orders.Take(10).ToList();
            return listado;
        }

        /// <summary>
        /// Permite consultar la información de una orden por su atributo id.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ServiciosWeb.WebApi.Models.Order Get(int id)
        {
            #region Variables
            ServiciosWeb.Datos.Modelo.Order orderBusinessModel;
            ServiciosWeb.WebApi.Models.Order orderViewModel;
            #endregion

            try
            {
                #region Consulta el modelo y retorna la data.
                orderBusinessModel = BD.Orders.FirstOrDefault(x => x.OrderID == id);
                orderViewModel = Mapper.Map<ServiciosWeb.Datos.Modelo.Order,
                                             ServiciosWeb.WebApi.Models.Order>(orderBusinessModel);

                return orderViewModel;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Permite insertar una orden.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public bool Post(ServiciosWeb.Datos.Modelo.Order order)
        {
            BD.Orders.Add(order);
            return BD.SaveChanges() > 0;
        }

        /// <summary>
        /// Permite actualizar una orden.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPut]
        public bool Put(ServiciosWeb.Datos.Modelo.Order order)
        {
            var orderToUpdate = BD.Orders.FirstOrDefault(x => x.OrderID == order.OrderID);

            // Sólo voy a actualizar el ShipName para probar.
            orderToUpdate.ShipName = order.ShipName;
         
            return BD.SaveChanges() > 0;
        }

        /// <summary>
        /// Permite eliminar una orden
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool Delete(int id)
        {
            var orderToDelete = BD.Orders.FirstOrDefault(x => x.OrderID == id);

            BD.Orders.Remove(orderToDelete);

            return BD.SaveChanges() > 0;
        }
    }
}