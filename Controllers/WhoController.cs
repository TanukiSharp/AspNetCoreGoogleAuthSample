using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreGoogleAuthSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            if (User.Identity.IsAuthenticated == false)
                return StatusCode(403, "Forbidden");

            return Content(User.Identity.Name);
        }
    }
}
