using ClassLibrary_SreeHealth;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sree_Health.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult Doctor()
        {
            return View();
        }
        public ActionResult Patient()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public int GetUserRole()
        //{
        //    BusinessLib blib = new BusinessLib();
        //    PropertyLib plib = new PropertyLib();
        //    plib.UserID = User.Identity.GetUserId();
        //    return blib.GetUserRole_UserID(plib);
        //}

    }
}