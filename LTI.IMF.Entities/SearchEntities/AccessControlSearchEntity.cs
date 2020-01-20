using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.SearchEntities
{
    public class AccessControlSearchEntity
    {
        public UserSearchEntity UserSearchEntity { get; set; }
        public RoleSearchEntity RoleSearchEntity { get; set; }
    }
}
