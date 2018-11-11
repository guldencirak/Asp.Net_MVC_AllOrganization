using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AllOrganization.Models;
using AllOrganization.Service;

namespace AllOrganization.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin userLogin)
        {
            User user = null;

            if (ModelState.IsValid)
            {
                IUserLoginService loginService = new UserLoginServiceImpl();
                user = loginService.Login(userLogin);
            }

            return View(user);
        }
    }
}
