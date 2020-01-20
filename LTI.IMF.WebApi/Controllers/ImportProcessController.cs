//using System.Web.Http;
//using LTI.IMF.WebApi.Enumerators;
//using LTI.IMF.Objects.Models;
//using LTI.IMF.Service;
//using System.Linq;
//using System.Collections.Generic;
//using LTI.IMF.Objects.Entities;
//using System;
//using LTI.IMF.WebApi.Common;
//using System.Reflection;

//namespace LTI.IMF.WebApi.Controllers
//{
//    [RoutePrefix("api/importProcess")]
//    public class ImportProcessController : ApiController
//    {
//        private readonly IImportProcessService _importProcessService;
//        private ErrorLogging log = new ErrorLogging();

//        public ImportProcessController(IImportProcessService importProcessService)
//        {
//            _importProcessService = importProcessService;
//        }
//        [HttpPost]
//        [Route("uploadFile")]
//        [SecurityLevel(MinSecurityLevel = SecurityLevel.Read, SecuritySection = SecuritySection.Security)]
//        public IHttpActionResult uploadFile(DataTape filedata)
//        {
//            try
//            {
//                return Ok(_importProcessService.ProcessFileData(filedata));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }

//        }
//        [HttpGet]
//        [Route("logExist")]
//        public IHttpActionResult LogExist(string logCode)
//        {
//            try
//            {
//                var logObject = _importProcessService.LogExist(logCode);
//                return Ok(logObject);
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }
//    }
//}
