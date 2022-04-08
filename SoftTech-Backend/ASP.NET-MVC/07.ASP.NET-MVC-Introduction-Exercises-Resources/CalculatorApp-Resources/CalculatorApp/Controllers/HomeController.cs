using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }
        
        [HttpPost]
        public ActionResult Calculate(Calculator calculator)
        {
            calculator.Result = CalculateResult(calculator);

            return RedirectToAction("Index", calculator);
        }

        private decimal CalculateResult(Calculator calculator)
        {
            decimal result = 0;

            switch (calculator.Operator)
            {
                case "+":
                    result = calculator.LeftOperand + calculator.RightOperand;
                    break;
                case "-":
                    result = calculator.LeftOperand - calculator.RightOperand;
                    break;
                case "*":
                    result = calculator.LeftOperand * calculator.RightOperand;
                    break;
                case "/":
                    result = calculator.LeftOperand / calculator.RightOperand;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
