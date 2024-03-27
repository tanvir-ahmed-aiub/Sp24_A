using APIIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIIntro.Controllers
{
    public class HomeController : ApiController
    { 
        //default route works with request verbs
        public HttpResponseMessage Get()
        {
            string[] names = { "Tanvir","Sabbir","Rahim","Karim"};
            return Request.CreateResponse(HttpStatusCode.OK,names);
        }
        public HttpResponseMessage Post() {
            var p = new Person() { Id = 1, Name="Dmo",Age=34};

            return  Request.CreateResponse(HttpStatusCode.OK,p);
        }
        
    }
}
