using System.Web;
using System.Web.Mvc;

namespace HACK_MVC_BOOKSTORE_EF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
