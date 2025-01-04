using Microsoft.AspNetCore.Mvc;

namespace CinemaBackEnd.Controllers
{
    public class ShowTimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
