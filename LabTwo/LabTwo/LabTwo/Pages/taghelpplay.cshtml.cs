using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LabTwo.Pages
{
    public class taghelpplayModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int? ReferenceInt { get; set; }

        [BindProperty]
        public double DoubleNormal { get; set; }

        [BindProperty]
        public double? DoubleReference { get; set; }

        [BindProperty]
        public decimal DecimalNormal { get; set; }

        [BindProperty]
        public decimal? DecimalReference { get; set; }

        [BindProperty]
        public float FloatNormal { get; set; }

        [BindProperty]
        public float? FloatReference { get; set; }

        [BindProperty]
        public string StringText { get; set; }

        [BindProperty]
        public DateTime dateTime { get; set; }

        [BindProperty]
        public DateTime? dateTimeReference { get; set; }

    }
}