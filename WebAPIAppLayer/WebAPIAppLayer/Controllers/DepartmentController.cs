using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIAppLayer.Controllers
{
    public class DepartmentController : ApiController
    {
        [HttpGet]
        [Route("api/department/all")]
        public HttpResponseMessage Get() {
            var data = DepartmentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/department/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = DepartmentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/department/{id}/courses")]
        public HttpResponseMessage GetwithCourse(int id)
        {
            var data = DepartmentService.GetwithCourse(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
