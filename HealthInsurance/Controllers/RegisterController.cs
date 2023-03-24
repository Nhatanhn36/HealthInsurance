using Microsoft.AspNetCore.Mvc;
using HealthInsurance.Models;
using Microsoft.AspNetCore.Identity;

namespace HealthInsurance.Controllers
{
    public class RegisterController : Controller
    {
        private readonly HealthInsuranceContext _context;

        public RegisterController(HealthInsuranceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserLogin register)
        {
            if (ModelState.IsValid)
            {
                var user = new UserLogin
                {
                    Username = register.Username,
                    Password = register.Password
                };

                _context.UserLogins.Add(user);
                await _context.SaveChangesAsync();

                return RedirectToAction("Login", "Login");
            }

            return View(register);
        }
    }
}
