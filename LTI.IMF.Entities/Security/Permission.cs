using Ipm.Entities.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Security
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<NavigationDropDownItem> NavigationDropDownItems { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
