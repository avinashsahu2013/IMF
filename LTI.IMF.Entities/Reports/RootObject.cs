using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Reports
{
    public class RootObject
    {

        public List<datasets> datasets { get; set; }
        public List<string> lstYEARMONTH { get; set; }

    }

    public class Datum
    {
        public string x { get; set; }
        public int y { get; set; }
    }

    public class datasets
    {
        public List<Datum> data { get; set; }
        //public string borderColor { get; set; }
        public string strokeColor { get; set; }
        public string fill { get; set; }
        public string label { get; set; }
    }


}
