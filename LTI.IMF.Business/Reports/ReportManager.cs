using Ipm.Entities.Reports;
using Ipm.Entities.SearchEntities;
using Ipm.Interfaces.Api.ReportService;
using Ipm.Interfaces.Business.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Business.Reports
{
    public class ReportManager : IReportManager
    {               
        private readonly IReportService _reportService;

        public ReportManager(IReportService reportService)
        {            
            _reportService = reportService;
        }

        //public IEnumerable<FullReport> GetFullReport(List<int> countryCodes, List<int> categoryIds, List<int> years, List<int> months)
        public IEnumerable<FullReport> GetFullReport(ReportCriteria reportCriteria)
        {
            //return _reportService.GetFullReport(new List<int>(), new List<int>(), new List<int>(), new List<int>());
            return _reportService.GetFullReport(reportCriteria);
        }

        public IEnumerable<YesIndexReport> GetYesIndex(ReportCriteria reportCriteria)
        {
            return _reportService.GetYesIndex(reportCriteria);
        }

        public IEnumerable<IndexChangeReport> GetChangeIndex(ReportCriteria reportCriteria)
        {
            return _reportService.GetChangeIndex(reportCriteria);
        }
        public RootObject GetYesIndexChart(ReportCriteria reportCriteria)
        {
            return _reportService.GetYesIndexChart(reportCriteria);
        }
        public RootObject GetChangeIndexChart(ReportCriteria reportCriteria)
        {
            return _reportService.GetChangeIndexChart(reportCriteria);
        }


    }
}
