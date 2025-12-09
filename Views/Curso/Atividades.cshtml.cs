using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Projetositedeestudo.Views.Curso
{
    public class Atividades : PageModel
    {
        private readonly ILogger<Atividades> _logger;

        public Atividades(ILogger<Atividades> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}