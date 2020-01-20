using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AreaerWebApi.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //TEsting devops
        public string Get(int id)
        {
            int a = 0;
            return "value";
        }

        [HttpPost]
        [Route("callPost")]
        // POST api/values
        public IHttpActionResult callPost([FromBody]Person postData)
        {
            return Ok(postData);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class Person {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
