using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Projetositedeestudo.Views.Usuario
{
    public class Atualizar : PageModel
    {
        private readonly ILogger<Atualizar> _logger;

        public Atualizar(ILogger<Atualizar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}