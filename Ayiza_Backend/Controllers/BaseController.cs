using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ayiza_Backend.Controllers
{
    // This controller is inherited in all controllers and is responsibal for calling respactive services in the service layer.
    public class BaseController : ApiController
    {
        public IService service;
        //Constructor for basecontroller.
        public BaseController(IService service)
        {
            this.service = service;
        }
    }
}
