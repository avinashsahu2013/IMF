using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.SearchEntities
{
    public class LegacyProductSearchEntity
    {
        public string ProductTitle { get; set; }
        public string ReportTitle { get; set; }
        public string FinancialReportingTitle { get; set; }
        public string ProductNumber { get; set; }
        public string SeasonCode { get; set; }
        public string EpisodeCode { get; set; }
        public string DivisionOwner { get; set; }
        public string ProductType { get; set; }
        public string FinRptNumber { get; set; }
        public string NewFinRptNumber { get; set; }
        public bool IncludeParts { get; set; }
        public int AccountTypeId { get; set; }

    }
}
