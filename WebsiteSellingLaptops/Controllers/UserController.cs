using Microsoft.AspNetCore.Mvc;

namespace WebsiteSellingLaptops.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
