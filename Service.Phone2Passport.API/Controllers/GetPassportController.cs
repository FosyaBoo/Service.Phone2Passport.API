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

        // ����� � ������ ��� ������ �� ��� ������ �������
        [HttpGet(Name = "GetPassport")]
        public async Task<JsonResult> GetAsync(string number)
        {
            IBusinessProcessor processor = new BusinessProcessor();

            return new JsonResult(await processor.Start(number));
        }

        [HttpGet(Name = "GetPassport")]
        public async Task<JsonResult> Get(string FirstName, string LastName, string SurName)
        {
            IBusinessProcessor processor = new BusinessProcessor();
            return new JsonResult(await processor.Start(FirstName, LastName, SurName));
        }
    }
}