using System.Web;
using System.Web.Mvc;

namespace th_Comp2007_Lesson10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
