using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LabTwo.Pages
{
    

    public class greetingModel : PageModel
    {
        public string Message { get; set; } = "Hello";

        public void OnGet()
        {

            if (11 < DateTime.Now.Hour)
            {
                Message = "Afternoon";
            }
            else
            {
                Message = "Morning";
            }
        }
    }
}