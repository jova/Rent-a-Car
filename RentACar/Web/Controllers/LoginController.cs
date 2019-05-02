using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private ILoginService loginService;

        public LoginController(ILoginService _loginService)
        {
            loginService = _loginService;
        }

        public ActionResult Loginpage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Loginpage(LoginViewModel loginViewModel)
        {
            var result = loginService.Login(loginViewModel.Mail, loginViewModel.Password);

            if (result)
            {
                //kendi sayfasına yönlendirilecek
                return View();
            }
            else return View();
        }
    }
}