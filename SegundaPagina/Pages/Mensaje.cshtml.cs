using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SegundaPagina.Pages
{
    public class MensajeModel : PageModel
    {
        [BindProperty]
        public int mensaje { get; set; }
        public void OnGet(int mensaje)
        {
            this.mensaje = mensaje;
        }
    }
}
