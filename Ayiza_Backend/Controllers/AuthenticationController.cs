using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceLayer.Services;

namespace Ayiza_Backend.Controllers
{
    public class AuthenticationController : BaseController
    {
        public AuthenticationController(IService service) : base(service)
        {
        }
        [HttpGet]
        public HttpResponseMessage getId()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Rehan");
        }
    }
}
