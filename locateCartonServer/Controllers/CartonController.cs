using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vercodebulktest.Models;

namespace vercodebulktest.Controllers
{
    public class CartonController : ApiController
    {
        // POST api/values
        public object Post([FromBody] CartonRequestModel value)
        {
            return new CartonResponseModel();
        }

        // POST api/values
        public object GET()
        {
            var retval = "hello i am get of carton";
            return retval;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
