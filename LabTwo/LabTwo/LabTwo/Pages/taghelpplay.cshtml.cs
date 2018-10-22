using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty]
        public bool isContactAllowed { get; set; }

        [BindProperty]
        public string Season { get; set; }

        [BindProperty]
        public string[] SeasonList { get; set; } = { "", "", "", "" };

        [BindProperty]
        public bool BrowserDataList { get; set; }

        [BindProperty]
        public List<string> Connaught { get; set; }

        
        public List<SelectListItem> Connaughts { get; }
            = new List<SelectListItem>
            {
                new SelectListItem {Value ="Sligo", Text="Sligo"},
                new SelectListItem {Value ="Leitrim", Text="Leitrim"},
                new SelectListItem {Value ="Roscommon", Text="Roscommon"},
                new SelectListItem {Value ="Galway", Text="Galway"},
                new SelectListItem {Value ="Mayo", Text="Mayo"},
            };



       


    }
}