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

        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "×", Text ="Умножить" },
                new SelectListItem() { Value = "+", Text ="Сложить" },
                new SelectListItem() { Value = "-", Text ="Вычесть" },
                new SelectListItem() { Value = "/", Text ="Поделить" },
                new SelectListItem() { Value = "x^y", Text ="Возвести X в степень Y" },
                new SelectListItem() { Value = "x%y", Text ="Найти остаток" },
                new SelectListItem() { Value = "logx(y)", Text ="Найти логарифм Y по основанию X" },
                new SelectListItem() { Value = "max(x,y)", Text ="Найти максимальное значение между X и Y" }
            };
            return View();
        }

        [HttpPost]
        public ActionResult Index(
            double firstArgument,
            double secondArgument,
            string operation)
        {
            double result = 0;

            // switch из "фабрики" напрямую.
            switch (operation)
            {
                case "+":
                    AdditionCalculator addition = new AdditionCalculator();
                    result = addition.Calculate(firstArgument, secondArgument);
                    break;
                case "-":
                    SubstractCalculator substract = new SubstractCalculator();
                    result = substract.Calculate(firstArgument, secondArgument);
                    break;
                case "×":
                    MultiplyCalculator multiply = new MultiplyCalculator();
                    result = multiply.Calculate(firstArgument, secondArgument);
                    break;
                case "/":
                    DivisionCalculator division = new DivisionCalculator();
                    result = division.Calculate(firstArgument, secondArgument);
                    break;
                case "x^y":
                    ExponentationCalculator exponentation = new ExponentationCalculator();
                    result = exponentation.Calculate(firstArgument, secondArgument);
                    break;
                case "x%y":
                    RemainderCalculator remainder = new RemainderCalculator();
                    result = remainder.Calculate(firstArgument, secondArgument);
                    break;
                case "logx(y)":
                    LogarithmCalculator logarithm = new LogarithmCalculator();
                    result = logarithm.Calculate(firstArgument, secondArgument);
                    break;
                case "max(x,y)":
                    MaxCalculator max = new MaxCalculator();
                    result = max.Calculate(firstArgument, secondArgument);
                    break;
            }
            
            ViewBag.Result = result;
            
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "×", Text ="Умножить" },
                new SelectListItem() { Value = "+", Text ="Сложить" },
                new SelectListItem() { Value = "-", Text ="Вычесть" },
                new SelectListItem() { Value = "/", Text ="Поделить" },
                new SelectListItem() { Value = "x^y", Text ="Возвести X в степень Y" },
                new SelectListItem() { Value = "x%y", Text ="Найти остаток" },
                new SelectListItem() { Value = "logx(y)", Text ="Найти логарифм Y по основанию X" },
                new SelectListItem() { Value = "max(x,y)", Text ="Найти максимальное значение между X и Y" }
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