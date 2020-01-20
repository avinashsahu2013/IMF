//using Ipm.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Interfaces.Business.Security
{
    public interface ISecurityManager
    {
        //IEnumerable<Permission> GetPermissions(IPrincipal user);
        bool UserHasPermission(IPrincipal user, string permissionName);
        bool IsUser(IPrincipal user);
        bool IsDisabled(IPrincipal user);
    }
}
