namespace ccAvenue.ViewModel
{
    public class CcAvenueViewModel
    {
        public CcAvenueViewModel(string encryptionRequest, string accessCode, string checkoutUrl)
        {
            EncryptionRequest = encryptionRequest;
            AccessCode = accessCode;
            CheckoutUrl = checkoutUrl;
        }

        public string EncryptionRequest { get; set; }
        public string AccessCode { get; set; }
        public string CheckoutUrl { get; set; }
    }
}