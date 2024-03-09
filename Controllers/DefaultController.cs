using Microsoft.AspNetCore.Mvc;

namespace SiliconAssignemt_3.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
