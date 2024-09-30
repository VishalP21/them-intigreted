using Microsoft.AspNetCore.Mvc;
using them.BussinessEntity;
using them.BussinessService.Concreate;
using them.BussinessService.Interface;
using them.Database;

namespace them_intigreted.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(UserViewModel userViewModel)
        {
                _userService.adduser(userViewModel);
            TempData["message"] = "Data Add...";
            return RedirectToAction("display");
        }

        public IActionResult edit(int id)
        {
            var data = _userService.getuser(id);
            TempData["message"] = "Data Edit...";
            return View("Index",data);
        }

        

        public IActionResult display()
        {
            var data = _userService.getusers();
            return View(data);
        }

        [HttpGet]
        public IActionResult delete(int id)
        {
            _userService.deleteuser(id);
            TempData["message"] = "Data Delete...";
            return RedirectToAction("display");
        }

       
    }
}
