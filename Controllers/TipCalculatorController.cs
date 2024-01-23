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
        }    }
}