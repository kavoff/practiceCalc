using Microsoft.AspNetCore.Mvc;
using practiceCalcWeb.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using practiceCalc;


namespace practiceCalcWeb.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "×", Text ="×" },
                new SelectListItem() { Value = "+", Text ="+" },
                new SelectListItem() { Value = "-", Text ="-" },
                new SelectListItem() { Value = "/", Text ="/" }
            };
            return View();
        }

        [HttpPost]
        public ActionResult Index(
            double firstArgument,
            double secondArgument,
            string operation)
        {
            //double calculator = TwoArgumentsCalculator.CreateCalculator(operation);
            //double result = calculator;

            //double calculator = CreateCalculator(operation);
            //double result = calculator;

            double result = TwoArgumentsCalculator.CreateCalculator(operation);
            // double result = calc.Calculate(firstArgument, secondArgument);
            
            // double result = new AdditionCalculator().Calculate(firstArgument, secondArgument);
            

            ViewBag.Result = result;

            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "×", Text ="×" },
                new SelectListItem() { Value = "+", Text ="+" },
                new SelectListItem() { Value = "-", Text ="-" },
                new SelectListItem() { Value = "/", Text ="/" }
            };
            
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}