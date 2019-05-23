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
    public class LoginController : ApiController
    {
        ILoginService loginService;
        public LoginController()
        {
            loginService = Business.IOCUtil.Resolve<ILoginService>();
        }

        // POST api/login
        public bool Post([FromBody]User user)
        {
            bool isLoggedIn = loginService.Login(user.UserName, user.UserPassword);
            return isLoggedIn;
        }
    }
}