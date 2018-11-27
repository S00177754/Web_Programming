using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ValStarter.Models;

namespace WeekEight.Pages
{
    public class ConfirmStudentModel : PageModel
    {
        //Variables
        [BindProperty]
        public Student StudentConfirm { get; set; } = new Student();
        public bool Error { get; private set; }

        //public string[] DateTimeConversion = new string[3];

        public void OnGet()
        {
            #region Original Version
            //StudentConfirm.StudentID = HttpContext.Session.GetString("StudentID");
            //StudentConfirm.FirstName = HttpContext.Session.GetString("FirstName");
            //StudentConfirm.LastName = HttpContext.Session.GetString("LastName");
            //DateTimeConversion = (HttpContext.Session.GetString("DateOfBirth")).Split('/');
            //StudentConfirm.DateOfBirth = new DateTime(int.Parse(DateTimeConversion[2]), int.Parse(DateTimeConversion[1]), int.Parse(DateTimeConversion[0]));
            //StudentConfirm.NumberOfModules = int.Parse(HttpContext.Session.GetString("Modules"));
            //StudentConfirm.Height = int.Parse(HttpContext.Session.GetString("Height"));
            //StudentConfirm.Email = HttpContext.Session.GetString("Email");
            #endregion

            string value = HttpContext.Session.GetString("student");
            if (value != null)
            {
                Error = false;
                StudentConfirm = JsonConvert.DeserializeObject<Student>(value);
            }
            else
            {
                Error = true;
            }

        }

        public void OnPost()
        {
                var serialisedData = JsonConvert.SerializeObject(StudentConfirm);
                HttpContext.Session.SetString("studentConfirm", serialisedData);
             
        }
    }
}