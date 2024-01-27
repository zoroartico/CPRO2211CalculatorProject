using CPRO2211CalculatorProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPRO2211CalculatorProject.Controllers
{
    public class PriceQuotationController : Controller
    {
        [Route("quote")]
        [HttpGet]
        public IActionResult PriceQuotationView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PriceQuotationView(PriceQuotationModel pq)
        {
            return View(pq);
        }
    }
}
