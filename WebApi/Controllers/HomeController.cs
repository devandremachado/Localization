using Application.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStringLocalizer<Messages> _localizer;

        public HomeController(IStringLocalizer<Messages> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            string message = _localizer["Hello World"];

            var response = new
            {
                message = message,
                culture = CultureInfo.CurrentCulture.Name
            };

            return Ok(response);
        }
    }
}
