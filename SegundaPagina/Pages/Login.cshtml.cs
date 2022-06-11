using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SegundaPagina.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credentials credentials { get; set; }

        [BindProperty]
        public string login { get; set; }
        public void OnGet()
        {
            //Obtengo un string de la session
           login = HttpContext.Session.GetString("Login");
            //Si quiero obtener un int uso GetInt32
        }

        public IActionResult OnPost()
        {
            if(credentials.Username == "Julio" && credentials.Password == "123456")
            {
                HttpContext.Session.SetString("Login", "LogOn");
            }
            else
            {
                HttpContext.Session.SetString("Login", "LogOff");
            }

            return RedirectToPage("ControlLogin");
        }


        public class Credentials
        {
            [Required]
            public string Username { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

        }
    }
}
