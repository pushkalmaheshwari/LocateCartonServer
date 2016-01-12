namespace vercodebulktest.Models
{
    public class ThirdPartyAppRequest
    {

        #region Properties


        public string applicationId { get; set; }

        public string platform { get; set; }

        public string version { get; set; }

        public string versionCode { get; set; }

        public string buildVersion { get; set; }

        public ThirdPartyAppRequest()
        {
            applicationId = string.Empty;
            platform = string.Empty;
            version = string.Empty;
            versionCode = string.Empty;
            buildVersion = string.Empty;
        }

        #endregion

    }
}