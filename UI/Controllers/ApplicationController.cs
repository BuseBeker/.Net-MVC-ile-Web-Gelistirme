using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace UI.Controllers
{
    public class ApplicationController : Controller
    {

        ApplicationManager applicationManager = new ApplicationManager(new EfApplicationDal());
        DataAccessLayer.Concrete.Context context = new DataAccessLayer.Concrete.Context();

        [Authorize(Roles = "user")]
        public ActionResult Index(string username)
        {
            username = (string)Session["Rumuz"];
            int useridinfo = context.Users.Where(x => x.Rumuz == username).Select(y => y.UserID).FirstOrDefault();
            List<Application> applicationvalues = applicationManager.GetListByUser(useridinfo);
            applicationvalues = applicationvalues.Where(temp => temp.ApplicationStatus).ToList();
            return View(applicationvalues);
        }

        [Authorize(Roles = "admin, editör")]
        public ActionResult AdminIndex()
        {
            List<Application> applicationvalues = applicationManager.GetList();
            applicationvalues = applicationvalues.Where(temp => temp.ApplicationStatus).ToList();
            return View(applicationvalues);
        }


        [Authorize(Roles = "admin, editör")]
        public ActionResult AdminDetails(int id)
        {
            var applicationvalue = applicationManager.GetByID(id);
            return View(applicationvalue);
        }

        [HttpGet]
        public ActionResult AddApplication()
        {
            List<SelectListItem> valueProjectType = (from x in applicationManager.GetList().DistinctBy(p => p.ProjectType)
                                                     select new SelectListItem
                                                     {
                                                         Text = x.ProjectType,
                                                         Value = x.ProjectType.ToString()
                                                     }).ToList();

            ViewBag.valueProjectType = valueProjectType;
            return View();

        }

        [HttpPost]
        public ActionResult AddApplication(Application application)
        {

            ApplicationValidator applicationvalidator = new ApplicationValidator();
            string usernameinfo = (string)Session["Rumuz"];
            int useridinfo = context.Users.Where(x => x.Rumuz == usernameinfo).Select(y => y.UserID).FirstOrDefault();
            application.UserID = useridinfo;
            application.ApplicationStatus = true;
            application.ProjectStatus = 0;
            ValidationResult results = applicationvalidator.Validate(application);
            if (results.IsValid)
            {
                applicationManager.ApplicationAdd(application);
                TempData["Success"] = "Başvuru Başarıyla Oluşturuldu!";
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

        [Authorize(Roles = "user")]
        public ActionResult DeleteApplication(int id)
        {
            var applicationvalue = applicationManager.GetByID(id);
            applicationvalue.ApplicationStatus = false;
            applicationManager.ApplicationDelete(applicationvalue);
            TempData["Success"] = "Başvuru Başarıyla Silindi!";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult EditApplication(int id)
        {
            List<SelectListItem> valueProjectType = (from x in applicationManager.GetList().DistinctBy(p => p.ProjectType)
                                                     select new SelectListItem
                                                     {
                                                         Text = x.ProjectType,
                                                         Value = x.ProjectType.ToString()
                                                     }).ToList();

            ViewBag.valueProjectType = valueProjectType;

            var applicationvalue = applicationManager.GetByID(id);
            return View(applicationvalue);
        }

        [HttpPost]
        public ActionResult EditApplication(Application application)
        {
            application.ApplicationStatus = true;
            applicationManager.ApplicationUpdate(application);
            TempData["Success"] = "Başvuru Başarıyla Güncellendi!";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "user")]
        public ActionResult Details(int id)
        {
            var applicationvalue = applicationManager.GetByID(id);
            return View(applicationvalue);
        }


        [Authorize(Roles = "admin, editör")]
        public ActionResult AdminDegerlendirme(int id)
        {
            var applicationvalue = applicationManager.GetByID(id);
            return View(applicationvalue);
        }

        [Authorize(Roles = "admin, editör")]
        public ActionResult AdminOnay(int id)
        {
            var applicationvalue = applicationManager.GetByID(id);
            applicationvalue.ApplicationStatus = true;
            applicationvalue.ProjectStatus = 1;
            applicationManager.ApplicationUpdate(applicationvalue);
            TempData["Success"] = "Başvuru Başarıyla Değerlendirildi!";
            return RedirectToAction("AdminIndex");
        }

        [Authorize(Roles = "admin, editör")]
        public ActionResult AdminRed(int id)
        {
            var applicationvalue = applicationManager.GetByID(id);
            applicationvalue.ApplicationStatus = true;
            applicationvalue.ProjectStatus = 2;
            applicationManager.ApplicationUpdate(applicationvalue);
            TempData["Success"] = "Başvuru Başarıyla Değerlendirildi!";
            return RedirectToAction("AdminIndex");
        }

        [Authorize(Roles = "admin, editör")]
        public ActionResult AdminOnayBekleyen()
        {
            List<Application> applicationvalues = applicationManager.GetList();
            applicationvalues = applicationvalues.Where(temp => temp.ApplicationStatus = true && temp.ProjectStatus == 0).ToList();
            return View(applicationvalues);
        }

    }
}