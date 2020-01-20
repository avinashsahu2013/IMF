using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using AreaerWebApi.Controllers;
using DatabaseFramework.Interfaces;
using Ipm.Entities.MasterData;
using Ipm.Interfaces.Api.MasterData;
using LTI.IMF.ApiService.MasterData;
using LTI.IMF.Business.MasterData;
using LTI.IMF.Interfaces.Business.MasterData;
using LTI.IMF.Interfaces.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.Pattern.UnitOfWork;
using System.Linq;

namespace LTI.IMF.WebApi.Tests.Controllers
{
    [TestClass]
    public class MasterDataControllerTest
    {
        //private readonly IMasterDataManager _masterDataManager;
        //[TestMethod]
        //public void GetAllCountries()
        //{
        //    MasterDataController controller = new MasterDataController(_masterDataManager);

        //    IHttpActionResult result = controller.GetCountries();
        //    var contentResult = result as OkNegotiatedContentResult<FilterCriteria>;
        //    Assert.IsNotNull(contentResult);
        //   // Assert.IsNotNull(contentResult.Content);
        //    //Assert.AreEqual(42, contentResult.Content.Id);
        //}

        //private readonly IMasterDataService _masterDataService;
        //[TestMethod]
        //public void GetAllCountries()
        //{
        //    MasterDataManager masterDataManager = new MasterDataManager(_masterDataService);

        //    FilterCriteria result = masterDataManager.GetCountries();
        //    Assert.IsNotNull(result.Countries);
        //    // Assert.IsNotNull(contentResult.Content);
        //    //Assert.AreEqual(42, contentResult.Content.Id);
        //}

        private readonly IUnitOfWork<IIMFDataContext> _imfUnitOfWork;
        private readonly IMasterDataManager _masterDataManager;

        [TestMethod]
        public void GetAllCountries()
        {

            //arrange
            var mockCortexBusinessManager = new Mock<IMasterDataManager>();

            //if GetResellerCustomersWithProperties is called with s123, return a new list of CustomerViewModel
            //with one item in, with id of 1
            mockCortexBusinessManager.Setup(m => m.GetCountries())
                .Returns(new FilterCriteria());


            MasterDataService masterDataManager = new MasterDataService(_imfUnitOfWork);

            //act
            var result = masterDataManager.GetCountries(); ;

            var countries = result.Countries;
            //assert
            Assert.AreEqual(227, countries.Count());
        //Assert.AreEqual(1, result.FirstOrDefault().Id)

            // Assert.IsNotNull(contentResult.Content);
            //Assert.AreEqual(42, contentResult.Content.Id);
        }
    }
}
