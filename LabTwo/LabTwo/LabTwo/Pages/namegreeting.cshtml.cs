using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LabTwo.Pages
{
    public class namegreetingModel : PageModel
    {
        public string Message { get; set; } = "";
        public void OnGet()
        {
            
        }

        public void OnPost(string firstname)
        {
            Message = "Hello " + firstname;
        }
    }
}