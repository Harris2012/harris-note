using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HarrisNote
{
    public class ListBoxDataInit
    {
        private static ListBoxDataInit dataInit;

        public static ListBoxDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new ListBoxDataInit();
                return dataInit;
            }
        }

        private ListBoxDataInit()
        {
            UserList = new List<UserInfo>()
            {
                new UserInfo(){
                    Header="群",
                    Name="DESKTOP-0N",
                    Info="我要像风一样自由!",
                    Count=3
                },
                new UserInfo(){
                    Header="张",
                    Name="张三丰",
                    Info="我要像风一样自由!",
                    Count=5
                },
                new UserInfo(){
                    Header="鬼",
                    Name="鬼见愁",
                    Info="我要像风一样自由!",
                    Count=2
                },
            };
        }
        public List<UserInfo> UserList { get; set; }
    }
}
