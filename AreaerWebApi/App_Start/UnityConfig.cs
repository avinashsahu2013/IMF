using DatabaseFramework.Interfaces;
using Ipm.Api.Common;
using Ipm.Api.ReportService;
using Ipm.Interfaces.Api.Common;
using Ipm.Interfaces.Api.MasterData;
using Ipm.Interfaces.Api.ReportService;
using LT.IMF.Data.UnitOfWork;
using LTI.IMF.ApiService.MasterData;
using LTI.IMF.Interfaces.Data;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace AreaerWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
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
                .RegisterType<IReportService, ReportService>();
            //Business
            //.RegisterType<IMasterDataManager, MasterDataManager>()
            //.RegisterType<IReportManager, ReportManager>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}