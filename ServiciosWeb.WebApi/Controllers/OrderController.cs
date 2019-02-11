using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiciosWeb.Datos.Modelo;
using ServiciosWeb.WebApi.Models;

namespace ServiciosWeb.WebApi.Controllers
{
    public class OrderController : ApiController
    {
        NorthwindConection BD = new NorthwindConection();

        /// <summary>
        /// Permite consultar la información de todas las órdenes.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderP> Get()
        {
            // var orders = BD.Orders.Take(2).ToList();
            var orders = (from o in BD.Orders
                          select new OrderP
                          {
                              orderID = o.OrderID,
                              customer = new CustomerP { CustomerID = o.Customers.CustomerID, CompanyName = o.Customers.CompanyName },
                              orderDate = o.OrderDate,
                              requiredDate = o.RequiredDate,
                              shippedDate = o.ShippedDate,
                              shipName = o.ShipName,
                              shipAddress = o.ShipAddress,
                              shipCity = o.ShipCity,
                              shipRegion = o.ShipRegion,
                              shipPostalCode = o.ShipPostalCode,
                              shipCountry = o.ShipCountry,
                              employee = new EmployeeP { EmployeeID = o.Employees.EmployeeID, FirstName = o.Employees.FirstName, LastName = o.Employees.LastName },
                              shipper = new ShipperP { ShipperID = o.Shippers.ShipperID, CompanyName = o.Shippers.CompanyName },
                              freight = o.Freight
                          }).Take(1).ToList();

            return orders;
        }
    }
}
