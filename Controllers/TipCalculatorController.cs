using CPRO2211CalculatorProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPRO2211CalculatorProject.Controllers
{
    public class TipCalculatorController : Controller
    {
        [Route("tip")]
        [HttpGet]
        public IActionResult TipCalculatorView()
        {
            ViewBag.Tip15 = 0;
            ViewBag.Tip20 = 0;
            ViewBag.Tip25 = 0;
            return View();
        }

        [HttpPost]
        public IActionResult TipCalculatorView(TipCalculator tc)
        {
            if (ModelState.IsValid)
            {
                var total = tc.Total;
                ViewBag.Tip15 = total * 0.15;
                ViewBag.Tip20 = total * 0.20;
                ViewBag.Tip25 = total * 0.25;
            }
            return View(tc);
        }
    }
}
