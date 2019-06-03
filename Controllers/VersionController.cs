using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreGoogleAuthSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : Controller
    {
        public const int CurrentVersion = 1;

        [HttpGet]
        public IActionResult Get()
        {
            return Content(CurrentVersion.ToString());
        }
    }
}
