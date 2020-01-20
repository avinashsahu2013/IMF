using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities
{
    public class Enums
    {
        public class Security
        {
            public class User
            {
                [Flags]
                public enum Includes
                {
                    None = 0,
                    Roles = 1 << 0,                         //1
                    RolesWithPermissions = 1 << 1,          //2
                    CreatedBy = 1 << 2,                     //4
                    UpdatedBy = 1 << 3,                     //8
                    All = RolesWithPermissions | CreatedBy | UpdatedBy
                }
            }
            public class Role
            {
                [Flags]
                public enum Includes
                {
                    None = 0,
                    Users = 1 << 0                        //1                                         //8                    
                }
            }
        }

        #region ActivityLog
        public class ActivityLog
        {
            public enum ActivityType
            {
                AddUser = 1,
                EditUser,
                DeleteUser,
                AddRole,
                RemoveRole,
                EnableDisableUser
            }
        }
        #endregion

        public class Website
        {
            public class NavigationBarItem
            {
                [Flags]
                public enum Includes
                {
                    None = 0,
                    DropDownHeaderWithDropDownItems = 1 << 0        //1
                }
            }
        }
    }
}
