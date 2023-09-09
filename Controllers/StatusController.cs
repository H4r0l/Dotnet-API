using Microsoft.AspNetCore.Mvc;

namespace dotnetAPI.Controllers
{
    [ApiController]
    [Route("custom")]
    public class StatusController : ControllerBase
    {
        private static readonly string Status = string.Empty;

        private readonly ILogger<StatusController> _logger;

        public StatusController(ILogger<StatusController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var result = new
            {
                status = "Status",
                Success = true
            };
            return new JsonResult(result);
        }
    }
}