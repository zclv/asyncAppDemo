using MyWebApiAOP.Unity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApiAOP.Controllers
{
    public class ValuesController : ApiController
    {
        private ITestAop _ta;
        public ValuesController(ITestAop  ta)
        {
            _ta = ta;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5  http://localhost:50824/api/Values?x=1&y=2
        public string Get(int x,int y)
        {
            return _ta.GetNum(x,y).ToString();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
}
