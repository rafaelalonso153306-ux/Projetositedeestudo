using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Projetositedeestudo.Views.Curso
{
    public class VerDetalhes : PageModel
    {
        private readonly ILogger<VerDetalhes> _logger;

        public VerDetalhes(ILogger<VerDetalhes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}