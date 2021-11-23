using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EvlQualiwareAPI.Models;

namespace EvlQualiwareAPI.Controllers
{
    [RoutePrefix("api/ApplcationFuntionality")]
    public class ApplicationFuntionalityController : ApiController
    {
        [AllowAnonymous]
        [Route("Create")]
        [ResponseType(typeof(ApplicationFuntionality))]
        [HttpPost]
        public async Task<IHttpActionResult> Create(ApplicationFuntionality funtionality)
        {
            throw new NotImplementedException();
        }
    }
}
