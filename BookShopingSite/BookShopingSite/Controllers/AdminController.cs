using Microsoft.AspNetCore.Mvc;

namespace BookShopingSite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
