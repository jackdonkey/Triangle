using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrianglesWebAPI.Models;

namespace TriAnglesWebAPI.Controllers
{
    public class TrianglesController : ApiController
    {
        // GET api/values http://localhost:60328/api/Triangles
        public IEnumerable<string> Get()
        {

            return new string[] { "value1" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }


        // POST api/values
        public string Post([FromUri]string value)
        {
            string[] valueSplit = value.Split('_');
            string buildParm  = valueSplit[0] + "," + valueSplit[1] + "," + valueSplit[2];
            
            return  AppDataContext.GetTriangleName(buildParm); ;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpPost]
        public IHttpActionResult Add(string title)
        {
            //Creates a Movie based on the Title
            return Ok();
        }


    }
}
