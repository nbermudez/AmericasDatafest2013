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

        public ActionResult Find(string location, string keywords, int pageNumber = 0) {
            Dictionary<string, string> searchOptions = new Dictionary<string, string>();
            
            searchOptions["location"] = location;
            searchOptions["pageNumber"] = pageNumber.ToString();
            searchOptions["keywords"] = keywords;

            List<JobOpportunity> jobOpportunities = JobSearchEngineFarm.GetJobOpportunities(searchOptions);

            ViewBag.Location = location;
            ViewBag.JobOpportunities = jobOpportunities;
            if (pageNumber > 0)
                ViewBag.PreviousUrl = "/JobFinding/Find?location=" + location + "&keywords=" + keywords + "&pageNumber=" + (pageNumber - 1);
            ViewBag.NextUrl = "/JobFinding/Find?location=" + location + "&keywords=" + keywords + "&pageNumber=" + (pageNumber + 1);

            return View();
        }

    }
}
