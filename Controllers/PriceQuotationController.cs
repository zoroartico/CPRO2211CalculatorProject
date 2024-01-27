using CPRO2211CalculatorProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPRO2211CalculatorProject.Controllers
{
    public class PriceQuotationController : Controller
    {
        //routing the pathway to /quote
        [Route("quote")]
        //setting the get request for the web server
        [HttpGet]
        public IActionResult PriceQuotationView()
        {
            ViewBag.Discount = 0;
            ViewBag.Total = 0;
            return View();
        }
        //setting the post request for the web server. This will activate on button click in the web form
        //if the request is valid, then it will update the discount and total fields
        [Route("quote")]
        [HttpPost]
        public IActionResult PriceQuotationView(PriceQuotationModel pq)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Discount = pq.Discount();
                ViewBag.Total = pq.Total();
            }
            else
            {
                ViewBag.Discount = 0;
                ViewBag.Total = 0;
            }
            return View(pq);
        }
    }
}
