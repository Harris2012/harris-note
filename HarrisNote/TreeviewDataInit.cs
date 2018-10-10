using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisNote
{
    public class TreeviewDataInit
    {
        private static TreeviewDataInit dataInit;

        public static TreeviewDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new TreeviewDataInit();
                return dataInit;
            }
        }
        private TreeviewDataInit()
        {
            OrgList = new ObservableCollection<OrgModel>();

            for (int i = 0; i < 3; i++)
            {
                var first = new OrgModel();
                first.DisplayName = "LL单位名称(3/7)";
                first.Children = new ObservableCollection<OrgModel>();
                OrgList.Add(first);

                for (int ij = 0; ij < 4; ij++)
                {
                    var second = new OrgModel();
                    second.DisplayName = "LL未分组联系人(2/4)";
                    second.Children = new ObservableCollection<OrgModel>();
                    first.Children.Add(second);

                    if (ij % 2 == 0)
                    {
                        continue;
                    }

                    for (int ijk = 0; ijk < 2; ijk++)
                    {
                        var third = new OrgModel();
                        third.DisplayName = "LLthree";
                        third.Name = "ijk" + ijk;
                        second.Children.Add(third);
                    }
                }
            }
        }
        public ObservableCollection<OrgModel> OrgList { get; set; }

    }
}
