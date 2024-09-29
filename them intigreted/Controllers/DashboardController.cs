using Microsoft.AspNetCore.Mvc;

namespace them_intigreted.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
