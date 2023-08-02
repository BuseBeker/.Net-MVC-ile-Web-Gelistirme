using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Security;
using static System.Net.Mime.MediaTypeNames;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        Context context = new Context();
        UserManager userManager = new UserManager(new EfUserDal());
        UserRoleManager userRoleManager = new UserRoleManager(new EfUserRoleDal());

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {   
            var userinfo = context.Users.FirstOrDefault(x => x.Rumuz == user.Rumuz && x.Password == user.Password);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.Rumuz, false);
                Session["Rumuz"] = userinfo.Rumuz;
                User user2 = context.Users.FirstOrDefault(y => y.Rumuz == user.Rumuz);
                UserRole role = context.UserRoles.Where(temp => temp.UserID == user2.UserID).FirstOrDefault();
                if (role.Role.RoleName == "user")
                {
                    return RedirectToAction("HomePage", "Home");
                }
                else
                {
                    return RedirectToAction("AdminHomePage", "Home");
                }
            }
            else
            {
                TempData["Error"] = "Kullanıcı Adı ya da Şifreniz Yanlış!";
                return RedirectToAction("Index");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }

        

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Register(User user)
        {
            UserValidator uservalidator = new UserValidator();
            user.UserStatus=true;



            ValidationResult results = uservalidator.Validate(user);
            if (results.IsValid)
            {
                userManager.UserAdd(user);

                Role defaultRole = context.Roles.SingleOrDefault(r => r.RoleName == "user");
                if (defaultRole != null)
                {
                    UserRole userRole = new UserRole();
                    userRole.UserID = user.UserID;
                    userRole.RoleID = defaultRole.RoleID;
                    userRole.Assigner = "system";
                    userRoleManager.UserRoleAdd(userRole);
                }
                TempData["Success"] = "Kaydınız Başarıyla Tamamlanmıştır! Giriş Yapabilirsiniz.";
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in results.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            } 
            return RedirectToAction("Register");
        }
    }
}