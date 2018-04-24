using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace HelperMethods.Web.Extensions
{
    public static class HtmlExtension
    {
        public static HtmlString HorizontalBox(this HtmlHelper helper)
        {
            return helper.Partial("~/Views/Shared/HorizontalBox.cshtml");
        }
    }
}