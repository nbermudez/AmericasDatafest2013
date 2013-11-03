using Potato.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Potato.Controllers
{
    public class JobFindingController : Controller
    {
        //
        // GET: /JobFinding/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Find(String location) {
            Dictionary<String, String> searchOptions = new Dictionary<string, string>();
            searchOptions["location"] = location;

            List<JobOpportunity> jobOpportunities = JobSearchEngineFarm.GetJobOpportunities(searchOptions);

            ViewBag.jobOpportunities = jobOpportunities;

            return View();
        }

    }
}
