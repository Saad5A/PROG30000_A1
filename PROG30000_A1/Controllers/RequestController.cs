using Microsoft.AspNetCore.Mvc;
using PROG30000_A1.Models;
namespace PROG30000_A1.Controllers
{
    public class RequestController : Controller
    {
        public IActionResult RequestForm()    //Url  GET : /student/CreateStudent
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestForm(EquipmentRequest request)  //URL: 
        {
            if (ModelState.IsValid)
            {
                Repository.AddRequest(request);
                return RedirectToAction("Confirmation");
            }
            else
            {
                return View(request);
            }

        }

        public IActionResult Confirmation()
        {
            return View();
        }
    } 
}
