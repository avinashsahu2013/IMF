using Ipm.Entities.SearchEntities;
using Ipm.Interfaces.Business.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AreaerWebApi.Controllers
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
        public IHttpActionResult GetFullReport(ReportCriteria reportCriteria)
        {
            try
            {
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
        [Route("getYesIndex")]
        public IHttpActionResult GetYesIndex(ReportCriteria reportCriteria)
        {
            try
            {
                var yesIndexReport = _reportManager.GetYesIndex(reportCriteria);
                return Ok(yesIndexReport);
            }
            catch (Exception ex)
            {
                //log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
                return Ok();
            }
        }

        [HttpPost]
        [Route("getChangeIndex")]
        public IHttpActionResult GetChangeIndex(ReportCriteria reportCriteria)
        {
            try
            {
                var changeIndexReport = _reportManager.GetChangeIndex(reportCriteria);
                return Ok(changeIndexReport);
            }
            catch (Exception ex)
            {
                //log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
                return Ok();
            }
        }

        [HttpPost]
        [Route("GetYesIndexChart")]
        public IHttpActionResult GetYesIndexChart(ReportCriteria reportCriteria)
        {
            try
            {
                var yesIndexReportChart = _reportManager.GetYesIndexChart(reportCriteria);
                return Ok(yesIndexReportChart);
            }
            catch (Exception ex)
            {
                //log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
                return Ok();
            }
        }


        [HttpPost]
        [Route("GetChangeIndexChart")]
        public IHttpActionResult GetChangeIndexChart(ReportCriteria reportCriteria)
        {
            try
            {
                var changeIndexReport = _reportManager.GetChangeIndexChart(reportCriteria);
                return Ok(changeIndexReport);
            }
            catch (Exception ex)
            {
                //log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
                return Ok();
            }
        }


    }
}
