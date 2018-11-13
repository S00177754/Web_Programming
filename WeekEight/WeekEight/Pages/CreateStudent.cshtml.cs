using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValStarter.Models;

namespace ValStarter.Pages
{
    public class CreateStudentModel : PageModel
    {

        [BindProperty]
        public Student Student { get; set; }

        public string message = "";

        public void OnPost()
        {
            if(Student.Email != Student.EmailConfirm)
            {
                message = "Emails so not match.";
            }
            else
            {
                message = "";
            }
        }
    }
}