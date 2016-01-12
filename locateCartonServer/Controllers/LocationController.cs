﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppScanThirdPartyIntegration;
using vercodebulktest.Business;
using vercodebulktest.Models;

namespace vercodebulktest.Controllers
{
    public class LocationController : ApiController
    {

        public PolicyResponseModel Get()
        {
            var biz = new PolicyBusines();
            return biz.GetAllPolicies();
        } 
        
        public object Post([FromBody]string value)
        {
            var biz = new PolicyBusines();
            return  biz.GetAllPolicies();
        }

        public object Get(int id)
        {
            return " hello you did get on location " + id;
        }

    }
}
