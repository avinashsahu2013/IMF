using Ipm.Entities.MasterData;
using Ipm.Interfaces.Api.MasterData;
using LTI.IMF.Entities.MasterData;
using LTI.IMF.Interfaces.Business.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.IMF.Business.MasterData
{
    public class MasterDataManager : IMasterDataManager
    {
        public MasterDataManager() { }

        private readonly IMasterDataService _masterDataService;        

        public MasterDataManager(IMasterDataService masterDataService)
        {
            _masterDataService = masterDataService;
        }
        public FilterCriteria GetCountries()
        {            
            return _masterDataService.GetCountries();
        }

        public bool AddCountry(string countryName)
        {
            return _masterDataService.AddCountry(countryName);
            
        }

        public bool AddCategory(string categoryName)
        {
            return _masterDataService.AddCategory(categoryName);
        }
    }
}
