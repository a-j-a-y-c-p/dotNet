using System.Diagnostics;
using FirstASPMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPMVC.Controllers
{

    // It will allow to have a controller with name not ending with "controller" but it is must to have "Controller" suffic
    public class HomeController : Controller // ControllerBase -> for APIs (which doesn't support views)
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) 
        {
            _logger = logger; // ctor dependency injection
        }

        public IActionResult Index()
        {
            return View(); // by default it return view of same name as of this action method (Index)
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
