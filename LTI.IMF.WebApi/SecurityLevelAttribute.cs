//using System;
//using System.Web.Http;
//using System.Web.Http.Controllers;
//using System.Reflection;
//using System.Security.Principal;
//using System.Net.Http;
//using System.Net;
//using LTI.IMF.WebApi.Enumerators;
//using LTI.IMF.Objects.Models;
//using LTI.IMF.Service;
//using LTI.IMF.Repositories;
//using LTI.IMF.Pattern;
//using LTI.IMF.Data;
//using System.Linq;

//namespace LTI.IMF.WebApi
//{
//    /// <summary>
//    /// SecurityLevelAttribute
//    /// </summary>
//    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
//    public class SecurityLevelAttribute : AuthorizeAttribute
//    {
//        public SecurityLevel MinSecurityLevel { get; set; }
//        public SecuritySection SecuritySection { get; set; }
//        protected override bool IsAuthorized(HttpActionContext actionContext)
//        {
//            //System.Security.Claims.ClaimsPrincipal claimsPrincipal = System.Security.Claims.ClaimsPrincipal.Current;
//            //string loginUserId = claimsPrincipal.Claims?
//            //        .Where(c => c.Type.Contains("nameidentifier"))
//            //        .Select(c => c.Value.Split('@')[0])
//            //        .FirstOrDefault();


//            //if (!base.IsAuthorized(actionContext)) { return false; }

//            //if (SecuritySection == SecuritySection.Undefined) { return true; }

//            //if (actionContext == null || String.IsNullOrEmpty(loginUserId)
//            //    || !claimsPrincipal.Identity.IsAuthenticated)
//            //{
//            //    return false;
//            //}

//            //UnitOfWork unitOfWork = new UnitOfWork(new CertsContext(), new UserFactory());

//            //ISecurityService securityService = new SecurityService(new SecurityRepository(unitOfWork));
//            //UserProfileModel user = securityService.Authorize(loginUserId);

//            //if (user.Id != 0)
//            //{
//            //    var properties = user.GetType().GetProperties();
//            //    foreach (PropertyInfo property in properties)
//            //    {
//            //        if (property.Name == SecuritySection.ToString())
//            //        {
//            //            if (int.Parse(property.GetValue(user).ToString()) >= (int)MinSecurityLevel) { return true; }
//            //            break;
//            //        }
//            //    }
//            //}

//            //if (user != null)
//            //{
//            //    var properties = user.GetType().GetProperties();
//            //    foreach (PropertyInfo property in properties)
//            //    {
//            //        if (property.Name == SecuritySection.ToString())
//            //        {
//            //            if (int.Parse(property.GetValue(user).ToString()) >= (int)MinSecurityLevel) { return true; }
//            //            break;
//            //        }
//            //    }
//            //}
//            //return false;
//            return true;
//        }
//        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
//        {
//            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
//            //base.HandleUnauthorizedRequest(actionContext);
//        }

//    }
//}
