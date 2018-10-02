using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LabTwo.Pages
{
    public class AdderModel : PageModel
    {
        public string Message { get; set; } = "";
        public void OnPost(double numOne, double numTwo,string action)
        {
            double total;


            switch (action.ToLower())
            {
                case "plus":
                    total = numOne + numTwo;

                    break;

                case "minus":
                    total = numOne - numTwo;
                    break;

                case "multiply":
                    total = numOne * numTwo;

                    break;

                case "divide":
                    total = numOne / numTwo;
                    break;

                default:
                    total = -999;
                    break;
            }
            Message = ($"{numOne} {action} {numTwo} equals {total}");
        }
    }
}