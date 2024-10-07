using Microsoft.AspNetCore.Mvc;

namespace IdentitySolution.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
