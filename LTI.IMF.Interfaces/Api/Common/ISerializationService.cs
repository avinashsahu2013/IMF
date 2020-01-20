using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Interfaces.Api.Common
{
    public interface ISerializationService
    {
        string ConvertToJson(object myObject);
    }
}
