using Microsoft.AspNetCore.Mvc;
using Login_page_with_validations.Models;
using Login_page_with_validations.services;

namespace Login_page_with_validations.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            services.services.search(model);
            return View(model);
        }

        public IActionResult List()
        {
            return View(services.services.getall);
        }
    }
}
