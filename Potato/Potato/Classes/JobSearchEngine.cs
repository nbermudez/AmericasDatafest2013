using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Classes
{
    interface JobSearchEngine
    {
        List<JobOpportunity> GetJobOpportunities(Dictionary<String, String> parameters);
    }
}
