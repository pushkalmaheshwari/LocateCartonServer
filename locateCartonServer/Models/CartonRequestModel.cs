using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace vercodebulktest.Models
{
    public class CartonResponseModel
    {
        public string MessageString = "happy carton response";
        public int ErrorCode = 0;
    }

    public class CartonRequestModel
    {
        public string LocationBarcode;
        public string CartonBarcode;
    }
   
}