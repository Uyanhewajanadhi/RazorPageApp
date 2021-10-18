using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageAppJay.Models;

namespace RazorPageAppJay.Pages.Forms
{
    public class AddArticleModel : PageModel
    {
        [BindProperty]
        public RazorPageAppJay.Models.ArticleModel Article { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            //Save Model to the DB

            return RedirectToPage("/Index", new { Article.BookName });
        }
    }
}
