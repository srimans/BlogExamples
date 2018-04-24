namespace HelperMethods.Web.Content
{
    public class ContentService : IContentService
    {
        public bool UploadContent(string fileName)
        {
            throw new System.NotImplementedException();
        }

        //Here content type is passed as a dummy.
        //Real usage will come when you have a real life scenario with different category of files you want to upload
        //and store them in different folders. 
        //Here I will simply return a url.

        public string GetContentFullUrl(ContentType contentType,string fileName) =>
            $"http://www.bigfoto.com/{fileName}";
    }
}