

using Ipm.Entities.Reports;
using Ipm.Entities.SearchEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Interfaces.Business.Reports
{
    public interface IReportManager
    {
       IEnumerable<FullReport> GetFullReport(ReportCriteria reportCriteria);
        IEnumerable<YesIndexReport> GetYesIndex(ReportCriteria reportCriteria);
        IEnumerable<IndexChangeReport> GetChangeIndex(ReportCriteria reportCriteria);
        RootObject GetYesIndexChart(ReportCriteria reportCriteria);

        RootObject GetChangeIndexChart(ReportCriteria reportCriteria);


    }
}
