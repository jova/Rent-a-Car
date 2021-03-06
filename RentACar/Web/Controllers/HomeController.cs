﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client = new HttpClient();

        public HomeController()
        {
            client.BaseAddress = new Uri("http://localhost:52935/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public ActionResult Index()
        {
            HttpResponseMessage response = client.GetAsync("api/vehicles").Result;
            List<VehicleInformation> vehicles = response.Content.ReadAsAsync<List<VehicleInformation>>().Result;
            return View(vehicles);
        }
    }
}
