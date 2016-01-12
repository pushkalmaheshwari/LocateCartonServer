using System.Collections.Generic;

namespace vercodebulktest.Models
{
    public class AppsRequestModel
    {
        public List<ThirdPartyAppRequest> apps;
        public string callbackUri;

        public AppsRequestModel()
        {
            apps = new List<ThirdPartyAppRequest>();
        }
    }
}