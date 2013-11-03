using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Net;
using System.IO;

namespace Potato.Classes
{
    public class CareerBuilder : JobSearchEngine
    {
        private const string jobSearchUrl = "http://api.careerbuilder.com/v1/jobsearch";
        private static string developerKey = "WDHR7XV6R6D686TSYQ20";

        List<JobOpportunity> JobSearchEngine.GetJobOpportunities(Dictionary<string, string> searchOptions)
        {
            XmlDocument careerBuilderResponse = MakeRequest(jobSearchUrl + "?DeveloperKey=" + developerKey + "&" + DictionaryToRequestParamsString(searchOptions));

            List<JobOpportunity> jobOpportunities = ProcessResponse(careerBuilderResponse);

            return jobOpportunities;
        }

        private XmlDocument MakeRequest(string requestUrl) {
            HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(response.GetResponseStream());

            DebugUtils.PrintXmlToConsole(xmlDoc);
            return xmlDoc;
        }

        private string DictionaryToRequestParamsString(Dictionary<string, string> dictionary) {
            string result = "";
            result = "Location=" + dictionary["location"];

            return result;
        }

        private List<JobOpportunity> ProcessResponse(XmlDocument xmlDocument) {
            List<JobOpportunity> jobOpportunities = new List<JobOpportunity>();

            XmlNode results = xmlDocument.SelectSingleNode("/ResponseJobSearch/Results");
            XmlNodeList jobSearchResults = results.SelectNodes("JobSearchResult");

            foreach (XmlNode jobSearchResult in jobSearchResults) {
                string jobTitle = "";
                string company = "";
                string location = "";
                DateTime date = DateTime.Now;
                string similarJobOpportunities = "";

                JobOpportunity jobOpportunity = new JobOpportunity(jobTitle, company, location, date, similarJobOpportunities);

                jobOpportunities.Add(jobOpportunity);
            }

            return jobOpportunities;
        }
    }
}