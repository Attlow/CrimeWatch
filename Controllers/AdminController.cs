using Microsoft.AspNetCore.Mvc;

namespace CrimeWatch.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
