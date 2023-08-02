using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ErrorPageController : Controller
    {
        public ActionResult PageError()
        {
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Page401()
        {
            Response.StatusCode = 401;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }

        public ActionResult Page403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }

        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }

        public ActionResult Page500()
        {
            Response.StatusCode = 500;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Page400()
        {
            Response.StatusCode = 400;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");
        }

        public ActionResult Page402()
        {
            Response.StatusCode = 402;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");
        }

        public ActionResult Page405()
        {
            Response.StatusCode = 405;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");
        }

        public ActionResult Page406()
        {
            Response.StatusCode = 406;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");
        }

        public ActionResult Page407()
        {
            Response.StatusCode = 407;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");
        }

        public ActionResult Page408()
        {
            Response.StatusCode = 408;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page409()
        {
            Response.StatusCode = 409;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page410()
        {
            Response.StatusCode = 410;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page411()
        {
            Response.StatusCode = 411;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page412()
        {
            Response.StatusCode = 412;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page413()
        {
            Response.StatusCode = 413;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page414()
        {
            Response.StatusCode = 414;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page415()
        {
            Response.StatusCode = 415;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page416()
        {
            Response.StatusCode = 416;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page417()
        {
            Response.StatusCode = 417;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page421()
        {
            Response.StatusCode = 421;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page422()
        {
            Response.StatusCode = 422;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page423()
        {
            Response.StatusCode = 423;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page424()
        {
            Response.StatusCode = 424;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page425()
        {
            Response.StatusCode = 425;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page426()
        {
            Response.StatusCode = 426;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page428()
        {
            Response.StatusCode = 428;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page429()
        {
            Response.StatusCode = 429;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page431()
        {
            Response.StatusCode = 431;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page451()
        {
            Response.StatusCode = 451;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page501()
        {
            Response.StatusCode = 501;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page502()
        {
            Response.StatusCode = 502;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page503()
        {
            Response.StatusCode = 503;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page504()
        {
            Response.StatusCode = 504;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page505()
        {
            Response.StatusCode = 505;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page506()
        {
            Response.StatusCode = 506;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page507()
        {
            Response.StatusCode = 507;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page508()
        {
            Response.StatusCode = 508;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }

        public ActionResult Page511()
        {
            Response.StatusCode = 511;
            Response.TrySkipIisCustomErrors = true;
            return View("PageError");

        }
    }
}