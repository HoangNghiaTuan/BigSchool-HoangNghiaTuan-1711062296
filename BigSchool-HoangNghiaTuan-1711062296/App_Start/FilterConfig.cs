using System.Web;
using System.Web.Mvc;

namespace BigSchool_HoangNghiaTuan_1711062296
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
