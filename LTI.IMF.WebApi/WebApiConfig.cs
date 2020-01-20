using System.Web.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Ninject.Web.Common;
using Microsoft.Practices.Unity;
using Ipm.Interfaces.Api.Common;
using Ipm.Api.Common;
using Ipm.Interfaces.Api.MasterData;
using LTI.IMF.ApiService.MasterData;
using LTI.IMF.Interfaces.Business.MasterData;
using LTI.IMF.Business.MasterData;
using LT.IMF.Data.UnitOfWork;
using LTI.IMF.Interfaces.Data;
using DatabaseFramework.Interfaces;
using System.Web.Http.Cors;
using Ipm.Interfaces.Api.ReportService;
using Ipm.Api.ReportService;
using Ipm.Interfaces.Business.Reports;
using Ipm.Business.Reports;

namespace LTI.IMF.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container
                //Data
                .RegisterType<IUnitOfWork<IIMFDataContext>, IMFUnitOfWork>()
                //Api
                //.RegisterType<ILogger, Logger>(new InjectionProperty("LogPath", logpath))
                .RegisterType<ISerializationService, JsonSerializationService>()
                .RegisterType<ISqlConversionHelper, SqlConversionHelper>()
                .RegisterType<IMasterDataService, MasterDataService>()
                .RegisterType<IReportService, ReportService>()
                //Business
                .RegisterType<IMasterDataManager, MasterDataManager>()            
                .RegisterType<IReportManager, ReportManager>();
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);


            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Formatters.JsonFormatter.Indent = true;

            
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            config.Formatters.JsonFormatter.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            
        }
    }
}
