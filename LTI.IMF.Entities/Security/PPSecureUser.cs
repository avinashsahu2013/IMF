using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Security
{
    public class PPSecureUser
    {
        public Int16 UserId { get; set; }

        public Int16? DepartmentSeq { get; set; }
        public string Name { get; set; }
        public Byte NetwareUser { get; set; }
        public Byte Disabled { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public Byte RequirePassword { get; set; }
        public Byte SuperUser { get; set; }
        public Int16? MessageSeq { get; set; }
        public string Phone { get; set; }

        public string Fax { get; set; }
        public string Location { get; set; }

        public string Equipment { get; set; }
        public string DosVer { get; set; }

        public string WinVer { get; set; }

        public string Memory { get; set; }

        public string Processor { get; set; }

        public DateTime? LastLogin { get; set; }

        public DateTime? LastPassword { get; set; }

        public DateTime? Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Updated { get; set; }

        public string UpdatedBy { get; set; }

        public string AdName { get; set; }

        public Byte DMSAllBusinessUnits { get; set; }
    }
}
