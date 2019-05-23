using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace API.Controllers
{
    [EnableCors(origins: "http://localhost:60170", headers: "*", methods: "*")]
    public class RentsController : ApiController
    {
        IRentService rentService;

        public RentsController()
        {
            rentService = Business.IOCUtil.Resolve<IRentService>();
        }

        // GET api/rents
        public List<Rentalinformation> Get()
        {
            List<Rentalinformation> rentalinformations = rentService.GetAll();
            return rentalinformations;
        }

        // GET api/rents/5
        public Rentalinformation Get(int id)
        {
            Rentalinformation rentalinformation = rentService.Get(id);
            return rentalinformation;
        }
    }
}