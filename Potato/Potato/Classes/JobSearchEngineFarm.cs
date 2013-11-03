using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Potato.Classes
{
    public class JobSearchEngineFarm
    {
        private static List<JobSearchEngine> engines = new List<JobSearchEngine>() { new CareerBuilder() };

        public static List<JobOpportunity> GetJobOpportunities(Dictionary<String, String> searchOptions) {
            List<JobOpportunity> jobOpportunities = new List<JobOpportunity>();
            foreach (JobSearchEngine engine in engines) {
                jobOpportunities.AddRange(engine.GetJobOpportunities(searchOptions));
            }

            return jobOpportunities;
        }
    }
}