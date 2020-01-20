//using Ipm.Interfaces.Business.Security;
//using System;
//using System.Collections.Generic;
//using Ipm.Entities.Security;
//using System.Security.Principal;
//using Ipm.Interfaces.Api.Security;
//using Ipm.Entities;

//namespace Ipm.Business.Security
//{
//    public class AccessControlManager : IAccessControlManager
//    {
//        private readonly IAccessControlService _accessControlService;
//        private readonly IUserService _userService;
//        public AccessControlManager(IAccessControlService accessControlService, IUserService userService)
//        {
//            _accessControlService = accessControlService;
//            _userService = userService;
//        }
//        public IEnumerable<User> GetUsers()
//        {
//            return _accessControlService.GetUsers();
//        }
//        public IEnumerable<Role> GetRoles()
//        {
//            return _accessControlService.GetRoles();
//        }
//        public IEnumerable<Role> GetRolesWithApplication()
//        {
//            return _accessControlService.GetRolesWithApplication();
//        }
//        public IEnumerable<Role> GetRolesByUserId(int userId)
//        {
//            return _accessControlService.GetRolesByUserId(userId);
//        }
//        public bool InsertUser(User newUser, IPrincipal loggedInUser)
//        {
//            var createdByUser = _userService.GetUser(loggedInUser, Enums.Security.User.Includes.None);
//            newUser.Created = DateTime.Now;
//            newUser.CreatedById = createdByUser.Id;
//            //newUser.CreatedByUser = createdByUser;
//            newUser.Updated = DateTime.Now;
//            newUser.UpdatedById = createdByUser.Id;
//            //newUser.UpdatedByUser = createdByUser;
//            return _accessControlService.InsertUser(newUser, createdByUser);
//        }
//        public bool UpdateUser(User updatedUser, IPrincipal loggedInUser)
//        {
//            var updatedByUser = _userService.GetUser(loggedInUser, Enums.Security.User.Includes.None);
//            var userToUpdate = _userService.GetUser(updatedUser.Id);
//            var isStatusModified = updatedUser.IsDisabled != userToUpdate.IsDisabled;
//            userToUpdate.FirstName = updatedUser.FirstName;
//            userToUpdate.Email = updatedUser.Email;
//            userToUpdate.LastName = updatedUser.LastName;
//            userToUpdate.UserName = updatedUser.UserName;
//            userToUpdate.IsDisabled = updatedUser.IsDisabled;
//            userToUpdate.PPSecureID = updatedUser.PPSecureID;
//            userToUpdate.Updated = DateTime.Now;
//            userToUpdate.UpdatedById = updatedByUser.Id;
//            userToUpdate.UpdatedByUser = updatedByUser;
//            return _accessControlService.UpdateUser(userToUpdate, updatedByUser, isStatusModified);
//        }
//        public bool UpdateUserRoles(User updateUserRolesEntity, IPrincipal loggedInUser)
//        {               
//            var updatedByUser = _userService.GetUser(loggedInUser, Enums.Security.User.Includes.None);
//            return _accessControlService.UpdateUserRoles(updateUserRolesEntity, updatedByUser);            
//        }

//        public IEnumerable<ActivityLog> GetActivityLog()
//        {
//            return _accessControlService.GetActivityLog();
//        }

//        public PPSecureUser CheckUserInPPSecure(User updateEntity)
//        {
//            return _accessControlService.CheckUserInPPSecure(updateEntity);
//        }
//    }
//}
