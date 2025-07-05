using Microsoft.AspNetCore.Mvc;

namespace practiceASP.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index(int a=1, int b = 2)
        {
            ViewBag.a = a;
            ViewBag.b = b;
            return View();
        }
    }
}
