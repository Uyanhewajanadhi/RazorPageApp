using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

//This model is asosciated with the line 2:@model in Index.cshtml

namespace RazorPageAppJay.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string BookName { get; set; }

        //Responsible for showing the index.cshtml page.
        public void OnGet()
        {

            //can get the data
            if(string.IsNullOrWhiteSpace(BookName))
            {
                BookName = " Sincerely_J";
            }
        }
        
    }
}
