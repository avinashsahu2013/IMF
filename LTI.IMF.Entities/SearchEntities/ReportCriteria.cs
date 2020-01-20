using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.SearchEntities
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
