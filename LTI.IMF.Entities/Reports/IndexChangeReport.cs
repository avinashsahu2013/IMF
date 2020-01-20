using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Reports
{
    public class IndexChangeReport
    {
        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public int Year { get; set; }
        public int ChangeIndex { get; set; }
        public string Report { get; set; }
    }
}
