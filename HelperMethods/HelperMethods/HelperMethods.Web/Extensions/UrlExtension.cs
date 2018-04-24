using HelperMethods.Web.Content;
using System.Web.Mvc;

namespace HelperMethods.Web.Extensions
{   
    public static class UrlExtension
    {
        private static readonly IContentService _contentService = new ContentService();

        public static string Logo(this UrlHelper helper, string fileName)
        {
            return _contentService.GetContentFullUrl(ContentType.Photo, fileName);
        }
    }
}