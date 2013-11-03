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

        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
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

        string similarOpportunitiesUrl;

        public string SimilarOpportunitiesUrl
        {
            get { return similarOpportunitiesUrl; }
            set { similarOpportunitiesUrl = value; }
        }
        #endregion

        public JobOpportunity(string jobTitle, string description, string company, string location, string similarOpportunitiesUrl)
        {
            this.jobTitle = jobTitle;
            this.description = description;
            this.company = company;
            this.location = location;
            this.similarOpportunitiesUrl = similarOpportunitiesUrl;
        }
    }
}