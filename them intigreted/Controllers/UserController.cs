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
            return RedirectToAction("Index");
        }

       
    }
}
