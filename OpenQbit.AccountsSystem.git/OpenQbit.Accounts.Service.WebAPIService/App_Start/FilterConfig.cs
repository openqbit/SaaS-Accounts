using System.Web;
using System.Web.Mvc;

namespace OpenQbit.Accounts.Service.WebAPIService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
