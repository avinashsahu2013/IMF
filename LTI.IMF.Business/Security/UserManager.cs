//using Ipm.Interfaces.Business.Security;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Ipm.Entities.Security;
//using System.Security.Principal;
//using Ipm.Interfaces.Api.Security;
//using Ipm.Entities;

//namespace Ipm.Business.Security
//{
//    public class UserManager : IUserManager
//    {
//        private readonly IUserService _userService;
//        public UserManager(IUserService userService)
//        {
//            _userService = userService;
//        }
//        public User GetUser(int id)
//        {
//            return _userService.GetUser(id);
//        }

//        public User GetUser(IPrincipal user)
//        {
//            return _userService.GetUser(user, Enums.Security.User.Includes.None);
//        }


//        public string GetUserName(IPrincipal user)
//        {
//            return user.Identity.Name;
//        }
//        public User GetUserWithRoles(IPrincipal user)
//        {
//            return _userService.GetUser(user, Enums.Security.User.Includes.Roles);
//        }


//        public User GetUserWithPermissions(IPrincipal user)
//        {
//            return _userService.GetUser(user, Enums.Security.User.Includes.RolesWithPermissions);
//        }

//        public bool IsUser(IPrincipal user)
//        {
//            return _userService.IsUser(user);
//        }
//    }
//}
