using Microsoft.AspNetCore.Mvc;
using PROG30000_A1.Models;
namespace PROG30000_A1.Controllers
{
    public class RequestController : Controller
    {

        [HttpGet ("RequestForm")]
        public IActionResult RequestForm()   
        {
            return View();
        }

        [HttpPost ("RequestForm")]

        public IActionResult RequestForm(EquipmentRequest request) 
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

        [Route("Confirmation")]
        public IActionResult Confirmation()
        {
            return View();
        }
    } 
}
