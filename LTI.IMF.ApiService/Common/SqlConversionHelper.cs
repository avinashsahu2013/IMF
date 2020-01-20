using Ipm.Interfaces.Api.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Api.Common
{
    public class SqlConversionHelper : ISqlConversionHelper
    {

        private const string ParameterDelimiter = ",";

        public object DatabaseNullConversion(object o)
        {
            if (o == null)
            {
                return DBNull.Value;
            }
            return o;
        }

        public string ConvertToParameterList(IEnumerable<int> ids)
        {
            var result = "";
            if (ids == null)
            {
                return result;
            }
            foreach (var id in ids)
            {
                result += id + ParameterDelimiter;
            }
            if (result.Length > 0)
            {
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }

        public string ConvertToParameterList(IEnumerable<string> ids)
        {
            var result = "";
            if (ids == null)
            {
                return result;
            }
            foreach (var id in ids)
            {
                result += "'" + id + "'" + ParameterDelimiter;
            }
            if (result.Length > 0)
            {
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }

        public static string EscapeSqlCharacters(string sql)
        {
            return sql.Replace("'", "''");
        }

    }
}
