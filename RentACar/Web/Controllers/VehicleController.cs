using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class VehicleController : Controller
    {
        HttpClient client = new HttpClient();

        public VehicleController()
        {
            client.BaseAddress = new Uri("http://localhost:52935/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public ActionResult Index(int vehicleId)
        {
            HttpResponseMessage response = client.GetAsync("api/vehicles/" + vehicleId).Result;
            VehicleInformation vehicle = response.Content.ReadAsAsync<VehicleInformation>().Result;

            return View(vehicle);
        }
    }
}