//using System.Web.Http;
//using LTI.IMF.Service;
//using LTI.IMF.Objects.Models;
//using LTI.IMF.Objects.Entities;
//using log4net;
//using System.Reflection;
//using System;
//using LTI.IMF.WebApi.Common;
//using System.Collections.Generic;

//namespace LTI.IMF.WebApi.Controllers
//{
//    [RoutePrefix("api/datatape")]
//    public class DataTapeController : ApiController
//    {
//        private readonly IDataTapeService _dataTapeService;
//        private ErrorLogging log = new ErrorLogging();

//        public DataTapeController(IDataTapeService dataTapeService)
//        {
//            _dataTapeService = dataTapeService;
//        }

//        [Route("GetDataTape")]
//        [HttpPost]
//        public IHttpActionResult GetDataTape(SearchParams searchParam, int limit, int offset)
//        {
//            try
//            {
//                return Ok(_dataTapeService.GetDataTape(searchParam, limit, offset));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [Route("GetDataTapeByCodeStory")]
//        [HttpPost]
//        public IHttpActionResult GetDataTapeByCodeStory(SearchParams searchParam, int limit, int offset)
//        {
//            try
//            {
//                return Ok(_dataTapeService.GetDataTapeByCodeStory(searchParam, limit, offset));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), "GetDataTapeByCodeStory");
//                return Ok();
//            }
//        }


//        [Route("GetTapeDetails")]
//        public IHttpActionResult GetDataTape(int jobId, int limit, int offset,bool isLoadAll)
//        {
//            try
//            {
//                return Ok(_dataTapeService.GetDataTape(jobId, limit, offset, isLoadAll));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), "GetDataTape");
//                return Ok();
//            }
//        }

//        [Route("SaveDataTape")]
//        [HttpPost]
//        public IHttpActionResult SaveDataTape(DataTape dateTape)
//        {
//            try
//            {
//                return Ok(_dataTapeService.SaveDataTape(dateTape));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), "SaveDataTape");
//                return Ok();
//            }
//        }

//        [Route("DeleteDataTape")]
//        [HttpPost]
//        public IHttpActionResult DeleteDataTape(List<int> jobIds)
//        {
//            try
//            {
//                return Ok(_dataTapeService.DeleteDataTape(jobIds));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), "DeleteDataTape");
//                return Ok();
//            }
//        }

//        [Route("Search")]
//        [HttpGet]
//        public IHttpActionResult Search(string searchText, string searchColumn)
//        {
//            try
//            {
//                return Ok(_dataTapeService.Search(searchText, searchColumn));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), "Search");
//                return Ok();
//            }
//        }

//        [Route("GeneratePdfDataTapeList")]
//        [HttpPost]
//        public IHttpActionResult GeneratePdfDataTapeList(SearchParams searchParam, int totRecord)
//        {
//            try
//            {
//                return Ok(_dataTapeService.GeneratePdfDataTapeList(searchParam, totRecord));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }
//    }
//}
