using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValStarter.Models
{
    public class Student
    {
       [Required (ErrorMessage ="You must enter your Student ID.")]
       [RegularExpression(@"^[sS]\d{8}",ErrorMessage ="Student ID must be in the format S12345678")]
        public string StudentID { get; set; }

        [Required(ErrorMessage = "You must enter your first name.")]
        [MinLength(2,ErrorMessage ="First name must be at least two letters long.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter your last name.")]
        [MinLength(2,ErrorMessage = "Last name must be at least two letters long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="You must enter your date of birth.")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "You must enter your number of modules.")]
        [Display(Name ="Number of Modules")]
        [RegularExpression(@"[1-9]|\d\d\d*", ErrorMessage ="At least one module is required.")]
        public int NumberOfModules { get; set; }

        [Required(ErrorMessage = "You must enter your height.")]
        [Range(50,250,ErrorMessage ="Height must be between 50 and 250.")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "You must enter your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 

        [Required(ErrorMessage ="You must enter your email.")]
        [DataType(DataType.EmailAddress)]
        [Compare(nameof(Email),ErrorMessage ="Emails do not match.")]
        public string EmailConfirm { get; set; }
    }
}
