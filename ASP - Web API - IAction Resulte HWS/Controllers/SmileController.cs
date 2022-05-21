using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP___Web_API___IAction_Resulte_HWS.Controllers
{
    [ApiController]
    public class SmileController : ControllerBase
    {
        [Route("smile")]
        public IActionResult GetSmile()
        {
            return Accepted(":)");
        }
    }
}
