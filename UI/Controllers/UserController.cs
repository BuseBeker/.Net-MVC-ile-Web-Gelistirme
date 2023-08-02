using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());

        public ActionResult Index()
        {
            var UserValues = userManager.GetList();
            return View(UserValues);
        }

    }
}