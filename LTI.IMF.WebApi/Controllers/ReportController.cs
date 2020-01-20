using Ipm.Entities.SearchEntities;
using Ipm.Interfaces.Business.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LTI.IMF.WebApi.Controllers
{
    [RoutePrefix("api/reports")]
    [EnableCorsAttribute("*", "*", "*")]
    public class ReportController : ApiController
    {
        private readonly IReportManager _reportManager;
        public ReportController(IReportManager reportManager)
        {
            _reportManager = reportManager;
        }

        [HttpPost]
        [Route("getFullReport")]
        //public IHttpActionResult GetFullReport(int[] countryCodes, int[] categoryIds, int[] years, int[] months)
        public IHttpActionResult GetFullReport(ReportCriteria reportCriteria)
        {
            try
            {
                //var fullReport = _reportManager.GetFullReport(countryCodes.ToList(), categoryIds.ToList(), years.ToList(), months.ToList());
                var fullReport = _reportManager.GetFullReport(reportCriteria);
                return Ok(fullReport);
            }
            catch (Exception ex)
            {
                //log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
                return Ok();
            }
        }

        [HttpPost]
        [Route("getTest")]
        public IHttpActionResult GetTest(int[] cc)
        {
            try
            {
                //var fullReport = _reportManager.GetFullReport(countryCodes.ToList(), categoryIds.ToList(), years.ToList(), months.ToList());
                return Ok("Hello");
            }
            catch (Exception ex)
            {
                //log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
                return Ok();
            }
        }
    }
}
