using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CazhOn.CallBackAPI.Controllers
{
    [ApiController]
    [Route("~/api/v1/cuelink")]    
    public class CueLinkPostBackController : ControllerBase
    {
        private readonly ILogger<CueLinkPostBackController> _logger;

        public CueLinkPostBackController(ILogger<CueLinkPostBackController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> PostData([FromQuery] string amount, [FromQuery] string commission,
            [FromQuery] string transactionId, [FromQuery] string subId)
        {       
            var result = new string[] { "name","result"};
            return Ok(result);
        }

        [HttpGet]
        public string Get()
        {
            return "Success";
        }
        
    }
}
