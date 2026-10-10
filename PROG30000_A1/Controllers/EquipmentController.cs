using Microsoft.AspNetCore.Mvc;
using PROG30000_A1.Models;

namespace PROG30000_A1.Controllers
{
    public class EquipmentController : Controller
    {
        [Route("AllEquipment")]
        public IActionResult AllEquipment()
        {
            return View(Repository.AllEquipment);
        }

        [Route("AvailableEquipment")]
        public IActionResult AvailableEquipment()
        {
            return View(Repository.AvailableEquipment());
        }
    }
}
