using BusinessLayer.Concrete;
using FluentValidation.Results;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        RoleManager roleManager = new RoleManager(new EfRoleDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetRoleList() //rollerin listelenmesi
        {
            var rolevalues = roleManager.GetList();
            return View(rolevalues);
        }

        [HttpGet] // sayfa yüklendiği zaman çalışacak olan attribute
        public ActionResult AddRole()
        {
            return View(); // sadece sayfayı geri gönder diyoruz
        }


        [HttpPost] // sayfada bir şey post edildiği zaman sen çalış diyoruz
        public ActionResult AddRole(Role role)
        {
            RoleValidator roleValidator = new RoleValidator();
            ValidationResult results = roleValidator.Validate(role);

            if (results.IsValid)
            {
                roleManager.RoleAdd(role);
                TempData["Success"] = "Rol Başarıyla Oluşturuldu!";
                return RedirectToAction("GetRoleList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}