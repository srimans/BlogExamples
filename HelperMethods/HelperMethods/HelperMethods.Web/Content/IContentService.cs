namespace HelperMethods.Web.Content
{
    public interface IContentService
    {
        bool UploadContent(string fileName);
        string GetContentFullUrl(ContentType contentType, string fileName);
    }
}
