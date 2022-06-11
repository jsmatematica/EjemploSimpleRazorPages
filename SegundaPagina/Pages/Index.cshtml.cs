using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SegundaPagina.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        [BindProperty]
        public string mensaje { set; get; }


        public void OnGet()
        {
            this.mensaje = "Hola mundo";
            //guardo un string en la session
            HttpContext.Session.SetString("Login", "LoginOff");
            //si quiero guardar un int uso SetInt32

        }


        public void OnPostMensaje(string mensaje)
        {
            this.mensaje = mensaje;
        }
    }
}
