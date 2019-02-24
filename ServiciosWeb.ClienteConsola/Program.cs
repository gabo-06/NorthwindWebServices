using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiciosWeb.Datos.Modelo;

namespace ServiciosWeb.ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invocar servicio REST
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://localhost:56354/");

            var request = clienteHttp.GetAsync("api/Order").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Order>>(resultString);

                foreach (var item in listado)
                {
                    Console.WriteLine("ShipName: " + item.ShipName);
                }

                Console.ReadLine();
            }
        }
    }
}