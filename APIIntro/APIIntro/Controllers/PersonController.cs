using APIIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIIntro.Controllers
{
    //custom route
    public class PersonController : ApiController
    {
        [HttpGet]
        [Route("api/person/all")] //not / is allowed at begining
        public HttpResponseMessage GetAllPerson() {
            string[] names = { "Tanvir", "Sabbir", "Rahim", "Karim" };
            return Request.CreateResponse(HttpStatusCode.OK, names);
        }
        [HttpGet]
        [Route("api/person/{p_id}/name/{p_name}")]
        public HttpResponseMessage GetPerson(int p_id,string p_name) {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpPost]
        [Route("api/person/create")]
        public HttpResponseMessage Add(Person p)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
