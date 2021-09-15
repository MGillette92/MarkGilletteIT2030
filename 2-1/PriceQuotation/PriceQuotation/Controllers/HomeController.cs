using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = 0;
            ViewBag.Message2 = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                

                ViewBag.Message = model.CalculateDiscountAmount();
                ViewBag.Message2 = model.CalculatePriceQuotation(); ;

                return View();
            }
            else
            {
                ViewBag.Message = 0;
                ViewBag.Message2 = 0;
            }
            return View(model);
        }
    }
}