using Microsoft.AspNetCore.Mvc;

namespace IdentitySolution.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
