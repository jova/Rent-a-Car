using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private ILoginService loginService;

        public LoginController()
        {
            loginService = Business.IOCUtil.Resolve<ILoginService>();
        }

        public ActionResult Loginpage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Loginpage(User user)
        {
            var result = loginService.Login(user.UserName, user.UserPassword);

            if (result)
            {
                //kendi sayfasına yönlendirilecek
                return View();
            }
            return View();
        }
    }
}