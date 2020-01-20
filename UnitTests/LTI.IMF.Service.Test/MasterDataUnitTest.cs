using Ipm.Entities.MasterData;
using Ipm.Interfaces.Api.MasterData;
using LTI.IMF.Business.MasterData;
using LTI.IMF.Interfaces.Business.MasterData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.IMF.Service.Test
{
    [TestClass]
    class MasterDataUnitTest
    {

        private readonly IMasterDataService _masterDataService;
        [TestMethod]
        public void GetAllCountries()
        {
            MasterDataManager masterDataManager = new MasterDataManager(_masterDataService);

            FilterCriteria result = masterDataManager.GetCountries();
            Assert.IsNotNull(result.Countries);
            // Assert.IsNotNull(contentResult.Content);
            //Assert.AreEqual(42, contentResult.Content.Id);
        }

    }
}
