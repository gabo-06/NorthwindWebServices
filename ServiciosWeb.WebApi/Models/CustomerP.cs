using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWeb.WebApi.Models
{
    public class CustomerP
    {
        public string CustomerID { get; set; }

        [DisplayName("CLIENTE")]
        public string CompanyName { get; set; }
    }
}