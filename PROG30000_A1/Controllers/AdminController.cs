using Microsoft.AspNetCore.Mvc;
using PROG30000_A1.Models;

namespace PROG30000_A1.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet("/Requests")]
        public IActionResult Requests()
        {
            return View(Repository.GetRequests());
        }
    }
}
