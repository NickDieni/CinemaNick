using Microsoft.AspNetCore.Mvc;

namespace CinemaBackEnd.Controllers
{
    public class PostalCodeController : ControllerBase
    {
        private readonly MyDbCOntext dbCOntext;
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
