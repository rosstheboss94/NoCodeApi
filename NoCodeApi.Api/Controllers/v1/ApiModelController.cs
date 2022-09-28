using Microsoft.AspNetCore.Mvc;

namespace NoCodeApi.Api.Controllers.v1
{
    [Route("[controller]")]
    public class ApiModelController : Controller
    {
        private readonly ILogger<ApiModelController> _logger;

        public ApiModelController(ILogger<ApiModelController> logger)
        {
            _logger = logger;
        }

    }
}