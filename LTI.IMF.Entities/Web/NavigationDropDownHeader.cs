using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Web
{
    public class NavigationDropDownHeader
    {
        public int Id { get; set; }
        public int NavigationBarItemId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int DisplaySortOrder { get; set; }
        public NavigationBarItem NavigationBarItem { get; set; }
        public ICollection<NavigationDropDownItem> NavigationDropDownItems { get; set; }
    }
}
