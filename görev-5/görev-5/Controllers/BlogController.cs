using Microsoft.AspNetCore.Mvc;

namespace görev_5.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
