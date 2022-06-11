using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SegundaPagina.Pages
{
    public class ControlLoginModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("Login") == "LogOn")
            {
                return RedirectToPage("LoginOk");
            }
            else
            {
                return RedirectToPage("LoginError");
            }
        }
    }
}
