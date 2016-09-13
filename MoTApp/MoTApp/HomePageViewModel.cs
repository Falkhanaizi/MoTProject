using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTApp
{
    public class HomePageViewModel
    {
        public HomePageViewModel(Type pageType)
        {
            this.PageType = pageType;
            this.PageName = pageType.Name.Replace("Page","").Replace("_"," ");

        }

        public HomePageViewModel() { }

        public Type PageType { private set; get; }

        public string PageName { private set; get; }

        public string PageImage { get; set; }
    }
}
