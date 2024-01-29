using CPRO2211CalculatorProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPRO2211CalculatorProject.Controllers
{
    public class TipCalculatorController : Controller
    {
        //Declaring default route as const
        private const string DEF = "tip";
        //routing the pathway to /tip
        [Route(DEF)]
        //setting the get request for the web server
        [HttpGet]
        public IActionResult TipCalculatorView()
        {
            ViewBag.Tip15 = 0;
            ViewBag.Tip20 = 0;
            ViewBag.Tip25 = 0;
            return View();
        }
        //setting the post request for the web server. This will activate on button click in the web form
        //if the request is valid, then it will update the tip fields
        [Route(DEF)]
        [HttpPost]
        public IActionResult TipCalculatorView(TipCalculatorModel tc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tip15 = tc.Tip(15m);
                ViewBag.Tip20 = tc.Tip(20m);
                ViewBag.Tip25 = tc.Tip(25m);
            } 
            else
            { 
                ViewBag.Tip15 = 0; 
                ViewBag.Tip20 = 0; 
                ViewBag.Tip25 = 0; 
            }
            return View(tc);
        }
    }
}
