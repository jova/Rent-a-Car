using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AddKm
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52935/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Random rand = new Random();
            DateTime tempDate = DateTime.Now;
            int vehicleId = 5;

            HttpResponseMessage response = client.GetAsync("api/vehicles/" + vehicleId).Result;
            VehicleInformation vehicle = response.Content.ReadAsAsync<VehicleInformation>().Result;

            for (int i = 0; i < 6; i++)
            {
                tempDate = tempDate.AddDays(-1);
                LastKm lastKm = new LastKm();
                lastKm.Date = tempDate;
                lastKm.vehicleId = vehicleId;
                lastKm.Km = rand.Next(5000, 9000);

                response = client.PostAsJsonAsync("api/lastKms", lastKm).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("added: " + (i+1));
                }
            }

            Console.ReadKey();
        }
    }
}
