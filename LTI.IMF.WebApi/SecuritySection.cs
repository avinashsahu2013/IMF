using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.IMF.WebApi
{
    /// <summary>
    /// SecuritySection
    /// </summary>
    public enum SecuritySection
    {
        Undefined = 0,
        Events,
        TicketsHospitality,
        ConfirmationMails,
        Chargebacks,
        Payments,
        Invoices,
        Reports,
        TableMaintenance,
        Security
    }
}
