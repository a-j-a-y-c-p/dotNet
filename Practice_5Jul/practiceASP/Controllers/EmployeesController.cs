using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using practiceASP.Models;

namespace practiceASP.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {
            List<Employee> emp = Employee.GetAllEmployes();

            return View(emp);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            Employee emp = Employee.getSingleEmployee(id);
            return View(emp);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }


        //  METHOD 1 --> using IFormCollection

        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        //int EmpNo = int.Parse(collection["EmpNo"]);
        //        //string Name = collection["Name"];
        //        //decimal Basic = decimal.Parse(collection["Basic"]);
        //        //int DeptNo = int.Parse(collection["DeptNo"]);
        //        //Console.WriteLine(EmpNo);
        //        //Console.WriteLine(Name);
        //        //Console.WriteLine(Basic);
        //        //Console.WriteLine(DeptNo);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        // Method 2 --> using binding (input name should be same as HTML name attribute)
        //public ActionResult Create(int EmpNo, string Name, decimal Basic, int DeptNo)
        //{
        //    try
        //    {

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        // Method 3 --> using Model binding (Property names of model should be same as Html name attribute)
        public ActionResult Create(Employee emp)
        {

            if (!ModelState.IsValid) // return true when model is returning some error
                // example --> setter validation is throwing some error
            {

                foreach(ModelStateEntry value in ModelState.Values)
                {
                    string ExceptionMessages= "";


                    // This is not required as it is already being done by VS
                    string ErrorMessages = "";

                    foreach(ModelError item in value.Errors)
                    {
                        // errors from our thrown exceptions
                        if(item.Exception != null)
                        {
                            ExceptionMessages += item.Exception.Message;

                            // AddModelError(PropName,ErrorMsg)
                            // If we dont add this then our custom error messages that are
                            //          thrown by exceptions will not be shown in views
                            ModelState.AddModelError("", item.Exception.Message);
                        }

                        // errors from dataAnnotation
                        // This is not required as it is already being done by VS
                        if(item.ErrorMessage != null)
                        {
                            ErrorMessages += item.ErrorMessage;
                        }
                    }
                }

            }
            else
            {
                try
                {
                    Employee.Insert(emp);
                    ViewBag.msg = "success";
                    return View();
                    //return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ViewBag.msg = ex.Message;
                }
            }

            return View();

        }



        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee emp = Employee.getSingleEmployee(id);
            return View(emp);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            try
            {
                Employee.update(emp);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee emp = Employee.getSingleEmployee(id);
            return View(emp);
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Employee.delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
