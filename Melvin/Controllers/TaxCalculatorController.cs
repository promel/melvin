using Microsoft.AspNetCore.Mvc;

namespace Melvin.Controllers
{
    public class TaxCalculatorController : Controller
    {
        public IActionResult CalculateTax()
        {
            return View();
        }
    }
}
