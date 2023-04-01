using System.Web;
using System.Web.Mvc;

namespace second_Webapi_using_C_sharp_and_SQL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
