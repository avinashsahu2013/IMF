using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Interfaces.Api.Common
{
    public interface ISqlConversionHelper
    {
        object DatabaseNullConversion(object o);
        string ConvertToParameterList(IEnumerable<int> ids);
        string ConvertToParameterList(IEnumerable<string> ids);

    }
}
