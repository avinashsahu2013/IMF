using Ipm.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Web
{
    public class NavigationDropDownItem
    {
        public int Id { get; set; }
        public int NavigationDropDownHeaderId { get; set; }
        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Link { get; set; }
        public int DisplaySortOrder { get; set; }
        public NavigationDropDownHeader NavigationDropDownHeader { get; set; }
        public Permission Permission { get; set; }
    }
}
