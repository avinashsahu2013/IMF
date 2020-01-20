using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.IMF.WebApi
{
    /// <summary>
    /// Security Level
    /// </summary>
    [Flags]
    public enum SecurityLevel
    {
        //None = 0x00,
        Read = 0x01,
        Edit = 0x02,
        Delete = 0x03
        //Admin = 0x04
    }
}
