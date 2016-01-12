using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace vercodebulktest.Models
{
    public class AppsResponseModel
    {
        public List<ThirdPartyAppResponse> apps;
        public AppsResponseModel()
        {
             apps = new List<ThirdPartyAppResponse>();
        }

    }

  
}