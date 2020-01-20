using Ipm.Entities.Reports;
using Ipm.Entities.SearchEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Interfaces.Api.ReportService
{
    public interface IReportService
    {
        //IEnumerable<FullReport> GetFullReport(List<int> countryCodes, List<int> categoryIds, List<int> years, List<int> months);

        IEnumerable<FullReport> GetFullReport(ReportCriteria reportCriteria);
        IEnumerable<YesIndexReport> GetYesIndex(ReportCriteria reportCriteria);
        IEnumerable<IndexChangeReport> GetChangeIndex(ReportCriteria reportCriteria);
        RootObject GetYesIndexChart(ReportCriteria reportCriteria);
        RootObject GetChangeIndexChart(ReportCriteria reportCriteria);



    }
}
