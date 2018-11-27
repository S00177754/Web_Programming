using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ValStarter.Models;

namespace ValStarter.Pages
{
    public class CreateStudentModel : PageModel
    {

        [BindProperty]
        public Student Student { get; set; }

        public string message = "";

        public IActionResult OnPost()
        {
            if (Student.Email != Student.EmailConfirm)
            {
                message = "Emails do not match.";
            }
            else
            {
                message = "";
            }

            if (ModelState.IsValid)
            {
                //Data Transfer
                //HttpContext.Session.SetString("StudentID", Student.StudentID);
                //HttpContext.Session.SetString("FirstName", Student.FirstName);
                //HttpContext.Session.SetString("LastName", Student.LastName);
                //HttpContext.Session.SetString("DateOfBirth", Student.DateOfBirth.ToShortDateString());
                //HttpContext.Session.SetString("Modules", string.Format($"{Student.NumberOfModules}"));
                //HttpContext.Session.SetString("Height", string.Format($"{Student.Height}"));
                //HttpContext.Session.SetString("Email", Student.Email);
                var serialisedData = JsonConvert.SerializeObject(Student);
                HttpContext.Session.SetString("student", serialisedData);

                //Redirect
                return RedirectToPage("ConfirmStudent");
            }
            else
            {
                return Page();
            }
        }

        public void OnGet()
        {
            string value = HttpContext.Session.GetString("student");
            if (value != null)
            {
                Student = JsonConvert.DeserializeObject<Student>(value);
            }
            

        }

    }
}