using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Security
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public int ActivityTypeId { get; set; }
        public ActivityType Activity { get; set; }
        public int ActivityPerformedById { get; set; }        
        public User ActivityPerformedByUser { get; set; }
        public int ActivityPerformedOnId { get; set; }
        public User ActivityPerformedOnUser { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }              
    }
}
