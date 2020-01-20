using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreaerWebApi.Models
{
    public class ReportCriteria
    {
        public string countryCodeIds { get; set; }
        public string categoryCodeIds { get; set; }
        public string years { get; set; }

        public string months { get; set; }
        public string actionType { get; set; }

    }
}