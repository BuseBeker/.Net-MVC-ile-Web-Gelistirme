using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class AdminRoleController : Controller
    {
        // GET: AdminRole
        RoleManager roleManager = new RoleManager(new EfRoleDal());
        public ActionResult Index()
        {
            var rolevalues = roleManager.GetList();
            return View(rolevalues);
        }

        [HttpGet]
        public ActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRole(Role role)
        {
            RoleValidator rolevalidator = new RoleValidator();
            ValidationResult results = rolevalidator.Validate(role);
            if (results.IsValid)
            {
                roleManager.RoleAdd(role);
                return RedirectToAction("Index");
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

        public ActionResult DeleteRole(int id)
        {
            var rolevalue = roleManager.GetByID(id);
            roleManager.RoleDelete(rolevalue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditRole(int id)
        {
            var rolevalue = roleManager.GetByID(id);
            return View(rolevalue);
        }

        [HttpPost]
        public ActionResult EditRole(Role p)
        {   
            roleManager.RoleUpdate(p);
            return RedirectToAction("Index");
        }
    }
}