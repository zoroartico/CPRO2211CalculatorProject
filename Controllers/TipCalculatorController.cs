using CPRO2211CalculatorProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace CPRO2211CalculatorProject.Controllers
{
    public class TipCalculatorController : Controller
    {
        [Route("tip")]
        public IActionResult TipCalculatorView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TipCalculatorView(TipCalculator tc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tip15 = tc.Tip();
                ViewBag.Tip20 = tc.Tip();
                ViewBag.Tip25 = tc.Tip();
            }
            else
            {
                ViewBag.Tip15 = 0;
                ViewBag.Tip20 = 0;
                ViewBag.Tip25 = 0;
                ViewBag.Total = 0;
            }
            return View(tc);
        }
    }
}