//using System;
//using System.Collections.Generic;
//using Ipm.Entities.Security;
//using System.Security.Principal;
//using Ipm.Interfaces.Business.Security;
//using Ipm.Interfaces.Api.Security;
//using System.Linq;

//namespace Ipm.Business.Security
//{
//    public class SecurityManager : ISecurityManager
//    {
//        internal readonly IUserService _userService;

//        public SecurityManager(IUserService userService)
//        {
//            _userService = userService;
//        }

//        public IEnumerable<Permission> GetPermissions(IPrincipal user)
//        {
//            var userWithPermissions = GetUserWithPermissions(user);
//            if (userWithPermissions == null)
//            {
//                return new List<Permission>();
//            }
//            return userWithPermissions.Roles.SelectMany(r => r.Permissions);
//        }

//        public bool IsDisabled(IPrincipal user)
//        {
//            return _userService.GetUser(user, Entities.Enums.Security.User.Includes.None).IsDisabled;
//        }

//        public bool IsUser(IPrincipal user)
//        {
//            return _userService.IsUser(user);
//        }

//        public bool UserHasPermission(IPrincipal user, string permissionName)
//        {
//            var userWithPermissions = GetUserWithPermissions(user);
//            if (userWithPermissions == null)
//            {
//                return false;
//            }
//            return userWithPermissions.Roles.Any(r => r.Permissions.Any(p => p.Name == permissionName));
//        }

//        private User GetUserWithPermissions(IPrincipal user)
//        {
//            return _userService.GetUser(user, Entities.Enums.Security.User.Includes.RolesWithPermissions);
//        }
//    }
//}
