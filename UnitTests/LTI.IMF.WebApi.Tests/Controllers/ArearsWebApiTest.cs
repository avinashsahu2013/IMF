using AreaerWebApi.Controllers;
using LTI.IMF.Interfaces.Business.MasterData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LTI.IMF.WebApi.Tests.Controllers
{
    public class ArearsWebApiTest
    {
        MasterDataController _masterDataController;
        private readonly IMasterDataManager _masterDataManager;
        public ArearsWebApiTest()
        {
            _masterDataController = new MasterDataController(_masterDataManager);

        }

        [TestMethod]
        public void GetCountries()
        {
            
            //IHttpActionResult actionResult = _masterDataController.GetCountries();
            // Assert  
            //Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }
    }
}
