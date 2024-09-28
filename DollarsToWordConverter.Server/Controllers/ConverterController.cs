using DollarsToWordConverter.Server.Definitions;
using DollarsToWordConverter.Services;
using Microsoft.AspNetCore.Mvc;

namespace DollarsToWordConverter.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConverterController : ControllerBase
    {

        private readonly ILogger<ConverterController> _logger;
        private readonly INumberConversionService _numberConversionService;

        public ConverterController(ILogger<ConverterController> logger, INumberConversionService numberConversionService)
        {
            _logger = logger;
            _numberConversionService = numberConversionService;
        }

        [HttpPost]
        public IActionResult Convert([FromBody] ConverterRequest request)
        {
            var response = this._numberConversionService.ConvertToDollarsInWords(request.Value);
            return Ok(response);
        }
    }
}
