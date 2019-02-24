using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWeb.WebApi.Models
{
    public class Order
    {
        public int orderID { get; set; }

        /// <summary>
        /// Decha en que se generó la orden.
        /// </summary>
        [DisplayName("FECHA DE ORDEN")]
        public Nullable<System.DateTime> orderDate { get; set; }

        /// <summary>
        /// Fecha para cuando se requiere la orden.
        /// </summary>
        [DisplayName("FECHA REQUERIDA")]
        public Nullable<System.DateTime> requiredDate { get; set; }

        /// <summary>
        /// Fecha cuando se envió la orden.
        /// </summary>
        [DisplayName("FECHA DE ENVIO")]
        public Nullable<System.DateTime> shippedDate { get; set; }

        /// <summary>
        /// Coste del alquiler de la embarcación donde se transporta la orden.
        /// </summary>
        [DisplayName("FLETE")]
        public Nullable<decimal> freight { get; set; }

        /// <summary>
        ///   Nombre de la persona o empresa que recibe el envío.
        /// </summary>
        // [DisplayName("DESTINO (PERSONA/EMPRESA)")]
        // public string shipName { get; set; }

        /// <summary>
        /// Dirección a donde se envará la orden.
        /// </summary>
        // [DisplayName("DIRECCION DE ENVIO")]
        // public string shipAddress { get; set; }

        /// <summary>
        /// Ciudad a donde se envará la orden.
        /// </summary>
        // [DisplayName("CIUDAD DE ENVIO")]
        // public string shipCity { get; set; }

        /// <summary>
        /// Región/Departamento a donde se envará la orden.
        /// </summary>
        // [DisplayName("REGION DE ENVIO")]
        // public string shipRegion { get; set; }

        /// <summary>
        /// Código postal del país a donde se envará la orden.
        /// </summary>
        // [DisplayName("CODIGO POSTAL")]
        // public string shipPostalCode { get; set; }

        /// <summary>
        /// País a donde se envará la orden.
        /// </summary>
        // [DisplayName("PAIS DE ENVIO")]
        // public string shipCountry { get; set; }
    }
}