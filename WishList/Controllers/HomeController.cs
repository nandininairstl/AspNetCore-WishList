using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return RedirectToAction("Error");
        }
    }
}
