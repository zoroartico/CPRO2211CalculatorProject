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
            return View( new TipCalculatorModel() );
        }

        [HttpPost]
        public IActionResult TipCalculatorView(TipCalculatorModel tc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tip15 = tc.Tip(0.15m);
                ViewBag.Tip20 = tc.Tip(0.20m);
                ViewBag.Tip25 = tc.Tip(0.25m);
            }
            return View(tc);
        }
    }
}
