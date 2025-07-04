using Microsoft.AspNetCore.Mvc;

namespace FirstASPMVC.Controllers
{
    public class DefaultController : Controller
    {
        //binding - automatically giving the values to the variable provided its of same name
        public IActionResult Index(int? id, int a=1, int b=2)
        {
            if(id == 123)
                    return NotFound();

            Console.WriteLine(a + " " + b);

            // to pass something from controller to views
            // uses dynamic coding - (properties can be added on runtime)
            // internally uses class ExpendoObject 
            ViewBag.id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            return View();
        }
    }
}
