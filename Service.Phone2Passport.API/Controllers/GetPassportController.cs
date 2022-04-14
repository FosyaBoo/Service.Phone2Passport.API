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

        [HttpGet(Name = "GetPassport")]
        public string  Get(string number)
        {
            IBusinessProcessor processor = new BusinessProcessor(); 
            processor.Start(number);  
            return "";
        }
    }
}