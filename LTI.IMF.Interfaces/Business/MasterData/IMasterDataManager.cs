using Ipm.Entities.MasterData;
using LTI.IMF.Entities.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.IMF.Interfaces.Business.MasterData
{
    public interface IMasterDataManager
    {
        FilterCriteria GetCountries();
        bool AddCountry(string countryName);
        bool AddCategory(string categoryName);
        //bool AddIndicator(string indicatorName);

    }
}
