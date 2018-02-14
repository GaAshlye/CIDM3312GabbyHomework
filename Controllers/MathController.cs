using Microsoft.AspNetCore.Mvc; 
using System; 

namespace MathCalculator.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(string left, string right)
        {
            double leftOp = Convert.ToDouble(left);
            double rightOp = Convert.ToDouble(right);
            double sum = leftOp + rightOp;
             ViewData["Message"] =$"{left} plus {right} equals {sum}";
            return View(); 
        }
        public IActionResult Subtraction(string left, string right)
        {
            double leftOp = Convert.ToDouble(left);
            double rightOp = Convert.ToDouble(right);
            double sum = leftOp - rightOp;
             ViewData["Message"] =$"{left} minus {right} equals {sum}";
            return View(); 
        }
        public IActionResult Multiply(string left, string right)
        {
            double leftOp = Convert.ToDouble(left);
            double rightOp = Convert.ToDouble(right);
            double sum = leftOp * rightOp;
             ViewData["Message"] =$"{left} times {right} equals {sum}";
            return View();
        }

        public IActionResult Division(string left, string right)
        {
            double leftOp = Convert.ToDouble(left);
            double rightOp = Convert.ToDouble(right);
            double sum = leftOp / rightOp;

            if(rightOp == 0)
            {
                ViewData["Message"] = @"You can't divide by zero";

            }else{
                ViewData["Message"] =$"{left} divided by {right} equals {sum}";
            }
            return View();
        }
        public IActionResult Modulus(string left, string right)
        {
            double leftOp = Convert.ToDouble(left);
            double rightOp = Convert.ToDouble(right);
            double sum = leftOp % rightOp; 
             ViewData["Message"] =$"When divinding {left} by {right}, the remainder is {sum}";
            return View(); 
        }
    }
}