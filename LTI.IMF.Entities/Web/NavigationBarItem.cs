using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.Web
{
    public class NavigationBarItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Link { get; set; }
        public int DisplaySortOrder { get; set; }
        public bool IsDropDownItem { get; set; }
        public ICollection<NavigationDropDownHeader> NavigationDropDownHeaders { get; set; }
    }
}
