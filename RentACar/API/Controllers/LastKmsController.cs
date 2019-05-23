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
    public class LastKmsController : ApiController
    {
        ILastKmService lastKmService;

        public LastKmsController()
        {
            lastKmService = Business.IOCUtil.Resolve<ILastKmService>();
        }

        // POST api/lastKms
        public IHttpActionResult Post([FromBody]LastKm lastKm)
        {
            lastKmService.Add(lastKm);
            return Ok( new { success = true });
        }
    }
}