using Ipm.Interfaces.Api.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Api.Common
{
    public class JsonSerializationService : ISerializationService
    {
        public string ConvertToJson(object myObject)
        {
            var jsonSettings = new JsonSerializerSettings() { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore };
            jsonSettings.Converters.Add(new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss tt", DateTimeStyles = DateTimeStyles.AdjustToUniversal });
            jsonSettings.Converters.Add(new StringEnumConverter { CamelCaseText = true });
            var converted = JsonConvert.SerializeObject(myObject, Formatting.None, jsonSettings);
            return converted;
        }
    }
}
