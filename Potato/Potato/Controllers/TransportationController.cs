using Potato.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Potato.Controllers
{
    public class TransportationController : Controller
    {
        //
        // GET: /Transportation/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Path_Finder() {
            
            return View();
        }

        public ActionResult Transportation_Location() {
            
            return View();
        }
    }
}
