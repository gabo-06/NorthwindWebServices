using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWeb.WebApi.Models
{
    public class ShipperP
    {
        public int ShipperID { get; set; }

        [DisplayName("EMPRESA EXPEDIDORA")]
        public string CompanyName { get; set; }
    }
}