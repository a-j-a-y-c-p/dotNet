using Microsoft.AspNetCore.Mvc;

namespace FirstASPMVC.Controllers
{
    public class DefaultController : Controller
    {
        //binding - automatically giving the values to the variable provided its of same name
        public IActionResult Index(int? id, int a=1, int b=2)
        {

//            AcceptedAtActionResult
//AcceptedAtRouteResult
//AcceptedResult
//AntiforgeryValidationFailedResult
//BadRequestObjectResult
//BadRequestResult
//ChallengeResult
//ConflictObjectResult
//ConflictResult
//ContentResult
//CreatedAtActionResult
//CreatedAtRouteResult
//CreatedResult
//EmptyResult
//FileContentResult
//FileResult
//FileStreamResult
//ForbidResult
//HttpActionResult
//JsonResult
//LocalRedirectResult
//NoContentResult
//NotFoundObjectResult
//NotFoundResult
//ObjectResult
//OkObjectResult
//OkResult
//PhysicalFileResult
//RedirectResult
//RedirectToActionResult
//RedirectToPageResult
//RedirectToRouteResult
//SignInResult
//SignOutResult
//StatusCodeResult
//UnauthorizedObjectResult
//UnauthorizedResult
//UnprocessableEntityObjectResult
//UnprocessableEntityResult
//UnsupportedMediaTypeResult
//VirtualFileResult
//PartialViewResult
//ViewComponentResult
//ViewResult

            foreach (var item in derivedTypes)
            {
                Console.WriteLine(item.Name);
            }



            if (id == 123)
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
