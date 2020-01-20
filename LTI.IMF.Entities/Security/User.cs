using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Security
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public System.DateTime Created { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime Updated { get; set; }
        public int UpdatedById { get; set; }
        public System.DateTime? LastLogin { get; set; }
        public User CreatedByUser { get; set; }
        public User UpdatedByUser { get; set; }
        public bool IsDisabled { get; set; }
        public int? PPSecureID { get; set; }

        private bool _isPDSUser;

        public bool IsPDSUser
        {
            get
            {
                if (this.PPSecureID > 0)
                {
                    return true;
                }
                else
                {
                    return _isPDSUser = false;
                }
            }
        }
       
        public ICollection<Role> Roles { get; set; }
        public ICollection<ActivityLog> ActivitiesPerformed { get; set; }
        public ICollection<ActivityLog> ActivitiesOn { get; set; }

        public IEnumerable<Permission> GetPermissions()
        {
            return Roles.SelectMany(r => r.Permissions);
        }
        public bool HasPermission(string permission)
        {
            return GetPermissions().Where(p => p.Name == permission).Any();
        }
    }
}
