using Ipm.Entities.MasterData;
using LTI.IMF.Entities.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Interfaces.Api.MasterData
{
    public interface IMasterDataService
    {
        FilterCriteria GetCountries();
        bool AddCountry(string countryName);
        bool AddCategory(string categoryName);
        //bool AddIndicator(string indicatorName);
    }
}
