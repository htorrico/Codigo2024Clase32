using System.Web;
using System.Web.Mvc;

namespace Codigo2024Clase32
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
