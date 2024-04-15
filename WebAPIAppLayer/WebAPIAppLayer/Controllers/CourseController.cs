using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIAppLayer.Controllers
{
    public class CourseController : ApiController
    {
        [HttpPost]
        [Route("api/course/create")]
        public HttpResponseMessage Create(CourseDTO c) { 
            CourseService.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpGet]
        [Route("api/course/all")]
        public HttpResponseMessage Get() {
            var data = CourseService.Get();
            return Request.CreateResponse(HttpStatusCode.OK,data);

        }
    }
}
