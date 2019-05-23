using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace API.Controllers
{
    public class CustomerController : ApiController
    {
        ICustomerService customerService;

        public CustomerController()
        {
            customerService = Business.IOCUtil.Resolve<ICustomerService>();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        public Rentalinformation RentRequest(int TCNumber, int vehicleId, int howManyDays)
        {
            Rentalinformation rentalinformation = customerService.RentRequest(TCNumber, vehicleId, howManyDays);

            return rentalinformation;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}