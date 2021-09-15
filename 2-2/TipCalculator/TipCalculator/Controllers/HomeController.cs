using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = 0;
            ViewBag.Message2 = 0;
            ViewBag.Message3 = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {


                ViewBag.Message = model.CalculateTip15();
                ViewBag.Message2 = model.CalculateTip20();
                ViewBag.Message3 = model.CalculateTip25();


                return View();
            }
            else
            {
                ViewBag.Message = 0;
                ViewBag.Message2 = 0;
                ViewBag.Message3 = 0;
            }
            return View(model);
        }
    }
}