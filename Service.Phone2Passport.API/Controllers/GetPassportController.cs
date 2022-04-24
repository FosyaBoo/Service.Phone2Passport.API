using Microsoft.AspNetCore.Mvc;
using Service.Phone2Passport.Business;

namespace Service.Phone2Passport.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetPassportController : ControllerBase
    {
        private readonly ILogger<GetPassportController> _logger;

        public GetPassportController(ILogger<GetPassportController> logger)
        {
            _logger = logger;
        }

        // Метод с именем для вызова из под строки запроса

        [HttpGet(Name = "GetPassport")]
        public async Task<JsonResult> GetAsync(string? number,string? FirstName, string? LastName, string? SurName)
        {
            IBusinessProcessor processor = new BusinessProcessor();
            return new JsonResult(await processor.Start(number,FirstName, LastName, SurName));
        }
    }
}