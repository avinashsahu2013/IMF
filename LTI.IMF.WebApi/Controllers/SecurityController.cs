//using System.Web.Http;
//using LTI.IMF.WebApi.Enumerators;
//using LTI.IMF.Objects.Models;
//using LTI.IMF.Service;
//using System.Linq;
//using LTI.IMF.WebApi.Common;
//using System;
//using System.Reflection;
//using System.Web;
//using System.Collections.Generic;

//namespace LTI.IMF.WebApi.Controllers
//{
//    [RoutePrefix("api/security")]
//    public class SecurityController : ApiController
//    {
//        private readonly ISecurityService _securityService;
//        private ErrorLogging log = new ErrorLogging();

//        public SecurityController(ISecurityService securityService)
//        {
//            _securityService = securityService;
//        }

//        [Route("GetSecurityProfiles")]
//        [SecurityLevel(MinSecurityLevel = SecurityLevel.Read, SecuritySection = SecuritySection.Security)]
//        public IHttpActionResult GetSecurityProfiles()
//        {
//            try
//            {
//                return Ok(_securityService.GetSecurityProfiles());
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [Route("save")]
//        [SecurityLevel(MinSecurityLevel = SecurityLevel.Edit, SecuritySection = SecuritySection.Security)]
//        public IHttpActionResult SaveSecurityProfile(UserProfileModel model)
//        {
//            try
//            {
//                return Ok(_securityService.SaveSecurityProfile(model));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [HttpPost, Route("delete")]
//        [SecurityLevel(MinSecurityLevel = SecurityLevel.Delete, SecuritySection = SecuritySection.Security)]
//        public IHttpActionResult DeleteSecurityProfile(int id)
//        {
//            try
//            {
//                return Ok(_securityService.DeleteSecurityProfile(id));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [HttpGet, Route("authorize")]
//        [Authorize]
//        public IHttpActionResult Authorize()
//        {
//            try
//            {
//                string loginUserId = System.Security.Claims.ClaimsPrincipal.Current.Claims?
//                       .Where(c => c.Type.Contains("nameidentifier"))
//                       .Select(c => c.Value.Split('@')[0])
//                       .FirstOrDefault();

//                return Ok(_securityService.Authorize(loginUserId));
//                //string identityName = RequestContext.Principal.Identity.Name;
//                //return Ok(_securityService.Authorize(identityName.Substring(identityName.IndexOf("\\") + 1)));
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }

//        [HttpGet, Route("version")]
//        public IHttpActionResult getVersion()
//        {
//            try
//            {
//                List<string> data=new List<string>();
//                var instance = HttpContext.Current.ApplicationInstance;
//                Assembly asm = instance.GetType().BaseType.Assembly;
//                System.Version version = asm.GetName().Version;            
//                data.Add(version.ToString());
                
//                return Ok(data);
//            }
//            catch (Exception ex)
//            {
//                log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
//                return Ok();
//            }
//        }
//        [HttpGet]
//        [Route("KeepAlive")]
//        public void KeepAlive()
//        {
//            //do nothing
//        }
//    }
//}
