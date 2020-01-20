using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Reports
{
   public class YesIndexReport
    {

        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string CategoryName { get; set; }
        public string MonthName { get; set; }
        public int YesIndex { get; set; }
        public string Report { get; set; }
    }
}
