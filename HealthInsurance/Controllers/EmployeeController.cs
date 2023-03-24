using Microsoft.AspNetCore.Mvc;
using HealthInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthInsurance.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HealthInsuranceContext _context;

        public EmployeeController(HealthInsuranceContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
