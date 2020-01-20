//using LTI.IMF.Objects.Entities;
//using LTI.IMF.Service;
//using LTI.IMF.WebApi.Common;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web.Http;

//namespace LTI.IMF.WebApi.Controllers
//{
//    [RoutePrefix("api/log")]
//    public class LogController : ApiController
//    {
//        private readonly ILogService _logService;
//        private ErrorLogging log = new ErrorLogging();
//        public LogController(ILogService logService)
//        {
//            _logService = logService;
//        }


//        [Route("DeleteLog")]
//        [HttpPost]
//        public IHttpActionResult DeleteLog(int id)
//        {
//            try
//            {
//                return Ok(_logService.DeleteLog(id));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [Route("GetLog")]
//        public IHttpActionResult GetLog(int jobId)
//        {
//            try
//            {
//                return Ok(_logService.GetLog(jobId));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [Route("GetLogDetails")]
//        public IHttpActionResult GetLogDetails(int id)
//        {
//            try
//            {
//                return Ok(_logService.GetLogDetails(id));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [Route("SaveLog")]
//        [HttpPost]
//        public IHttpActionResult SaveLog(DataLog dataLog)
//        {
//            try
//            {
//                return Ok(_logService.SaveLog(dataLog));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }

//        }
//        [Route("GetCodes")]
//        public IHttpActionResult GetCodes()
//        {
//            try
//            {
//                return Ok(_logService.GetCodes());
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [Route("GetAvailableSequence")]
//        public IHttpActionResult GetAvailableSequence(int id, int jobId, string time, int interval)
//        {
//            try
//            {
//                return Ok(_logService.GetAvailableSequence(id, jobId, time, interval));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [Route("ValidateTime")]
//        [HttpGet]
//        public IHttpActionResult ValidateTime(int jobId, string time)
//        {
//            try
//            {
//                return Ok(_logService.ValidateTime(jobId, time));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }
//    }
//}
