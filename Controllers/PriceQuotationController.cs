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
            ViewBag.discount = 0;
            ViewBag.total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult PriceQuotationPost()
        {
            if (ModelState.IsValid)
            {
                PriceQuotationModel pq = new PriceQuotationModel();
                ViewBag.discount = pq.getDiscount(ViewBag.inputSubtotal, ViewBag.discountInput);
                Console.WriteLine(pq.getDiscount(ViewBag.inputSubtotal, ViewBag.discountInput));
                ViewBag.total = pq.getTotal(ViewBag.inputSubtotal, ViewBag.discountInput);
            }
            return View();
        }
    }
}
