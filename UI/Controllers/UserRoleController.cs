
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using EntityLayer.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Context = DataAccessLayer.Concrete.Context;

namespace UI.Controllers
{
    public class UserRoleController : Controller
    {
        // GET: UserRole
        UserRoleManager userRoleManager = new UserRoleManager(new EfUserRoleDal());
        RoleManager roleManager = new RoleManager(new EfRoleDal());
        UserManager userManager = new UserManager(new EfUserDal());

        //UserManager um = new UserManager(new EfUserDal());
        Context context = new Context();
        public ActionResult Index()
        {
            var userrolevalues = userRoleManager.GetList();
            return View(userrolevalues);
        }

        [HttpGet]
        public ActionResult AddUserRole()
        {

            //dropdownlist tanımlaması
            List<SelectListItem> valuerole = (from x in roleManager.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.RoleName,
                                                  Value = x.RoleID.ToString()
                                              }).ToList();

            List<SelectListItem> valueuser = (from x in userManager.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.Name + " " + x.Surname,
                                                  Value = x.UserID.ToString()
                                              }).ToList();
            ViewBag.vlr = valuerole;
            ViewBag.vlu = valueuser;
            return View();
        }

        [HttpPost]
        public ActionResult AddUserRole(UserRole userRole)
        {
            //p.RecordDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            userRoleManager.UserRoleAdd(userRole);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditUserRole(int id)
        {

            List<SelectListItem> valuerole = (from x in roleManager.GetList()/*.DistinctBy(p => p.Role.RoleName)*/
                                              select new SelectListItem
                                              {
                                                  Text = x.RoleName,
                                                  Value = x.RoleID.ToString()
                                              }).ToList();

            ViewBag.valuerole = valuerole;
            var userrolevalue = userRoleManager.GetByID(id);
            userRoleManager.UserRoleDelete(userrolevalue);
            return RedirectToAction("AddUserRole");
            //List<SelectListItem> valuerole = (from x in userRoleManager.GetList().DistinctBy(p => p.Role.RoleName)
            //                                  select new SelectListItem
            //                                  {
            //                                      Text = x.Role.RoleName,
            //                                      Value = x.RoleID.ToString()
            //                                  }).ToList();

            //ViewBag.valuerole = valuerole;
            //var userrolevalue = userRoleManager.GetByID(id);
            //return View(userrolevalue);
        }


        [HttpPost]
        public ActionResult EditUserRole(UserRole userRole)
        {
            //userRoleManager.UserRoleUpdate(userRole);
            return RedirectToAction("Index");


            ////public ActionResult EditUserRole(UserRole userRole, int roleid)
            ////if (userRole != null && userRole.UserID > 0)
            ////{
            ////    userRole.RoleID = roleid;
            ////    userRoleManager.UserRoleUpdate(userRole);
            ////    TempData["Success"] = "Kullanıcı Rolü Başarıyla Güncellendi!";
            ////}
            ////else
            ////{
            ////    TempData["Error"] = "Kullanıcı Rolü Güncellenemedi!";
            ////}

            ////return RedirectToAction("Index");
        }

            //if(ModelState.IsValid)
            //{
            //    var userRole = userRoleManager.GetByID(p.UserRoleID);
            //    if (userRole == null)
            //    {
            //        return HttpNotFound();
            //    }

            //    userRole.RoleID = SelectedRoleId;
            //    userRoleManager.UserRoleUpdate(userRole);

            //    return RedirectToAction("Index");
            //}


            //var userrolevalue = userRoleManager.GetByID(id);
            //userrolevalue.RoleID = model.SelectedRoleId;
            //userRoleManager.UserRoleUpdate(userrolevalue);
            //return RedirectToAction("Index");
            //if (p != null && p.UserID > 0)
            //{
            //    //p.RoleID = roleid;
            //    userRoleManager.UserRoleUpdate(p);
            //}
            //else
            //{
            //    //show message
            //}

            //return RedirectToAction("Index");
        }
    
}