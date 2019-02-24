using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using ServiciosWeb.Dominio;

namespace ServiciosWeb.ClienteWeb.Controllers
{
    public class OrderController : Controller
    {
        // GET: Libro
        public ActionResult Index()
        {
            // Invocar servicio REST
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://localhost:56354/");

            var request = clienteHttp.GetAsync("api/Order").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Order>>(resultString);

                return View(listado);
            }

            return View(new List<Order>());
        }
    }
}