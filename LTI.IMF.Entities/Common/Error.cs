using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Common
{
    public class Error
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string InnerErrorMessage { get; set; }
        public string Location { get; set; }
        public System.DateTime? TimeOfErrorInUTC { get; set; }
    }
}
