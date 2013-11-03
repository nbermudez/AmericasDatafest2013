using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Potato.Classes
{
    public class JobOpportunity
    {
        #region Attributes
        string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        string similarOpportunitiesUrl;

        public string SimilarOpportunitiesUrl
        {
            get { return similarOpportunitiesUrl; }
            set { similarOpportunitiesUrl = value; }
        }
        #endregion

        public JobOpportunity(string jobTitle, string company, string location, DateTime date, string similarOpportunitiesUrl)
        {
            this.jobTitle = jobTitle;
            this.company = company;
            this.location = location;
            this.date = date;
            this.similarOpportunitiesUrl = similarOpportunitiesUrl;
        }
    }
}