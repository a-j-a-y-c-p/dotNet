using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using practiceASP.Models;

namespace practiceASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.a = 1;
            ViewData["b"] = 2;
            TempData["c"] = 3;

            byte[] arr;

            // each httpContect is for one request

            // METHOD 1
            //HttpContext.Session.Set("key1", arr);
            //arr = HttpContext.Session.Get("key2");

            // METHOD 2
            //HttpContext.Session.SetString("key2", "abc");
            //HttpContext.Session.SetInt32("key3", 234);
            //// returns nullable
            //int? a = HttpContext.Session.GetInt32("key3");
            //int a1 = HttpContext.Session.GetInt32("key3").Value;

            // ----->
            //To store a object, first we need to serialize it to a jsonString and then store,
            // while retriving it we will get the jsonStirng and deserialize it to object
            //Employee emp = Employee { EmpNo = 1}/;
            //string jsonString = JsonSerializer.Serialize(emp);
            //HttpContext.Session.SetString("emp", jsonString);

            //string outStirng = HttpContext.Session.GetString("emp");
            //Employee empOut = JsonSerializer.Deserialize<Employee>(outStirng);

            // MEHTOD 3


            return View();
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
