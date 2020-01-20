using LTI.IMF.Entities.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.MasterData
{
    public class FilterCriteria
    {
     
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Year> Years { get; set; }
        public IEnumerable<Month> Months { get; set; }
    }
}
