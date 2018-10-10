using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisNote
{
    public class OrgModel
    {
        public bool IsGrouping
        {
            get
            {
                return Children != null && Children.Count > 0;
            }
        }
        public ObservableCollection<OrgModel> Children { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
    }
}
