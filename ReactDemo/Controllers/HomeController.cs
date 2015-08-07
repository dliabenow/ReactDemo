using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult Contacts()
        {
            ContactController ac = new ContactController();

            var contacts = ac.GetContacts();
            return Json(contacts, JsonRequestBehavior.AllowGet);
        }

        //[OutputCache(Location = OutputCacheLocation.None)]
        //public ActionResult Contacts()
        //{
        //    System.Web.Http.HttpConfiguration config = new System.Web.Http.HttpConfiguration();

        //    ContactController ac = new ContactController();

        //    var contacts = ac.GetContacts();
        //    return Json(contacts, JsonRequestBehavior.AllowGet);
        //}
    }
}