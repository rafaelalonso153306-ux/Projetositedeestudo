using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class ConteudoController : Controller
    {
        private readonly ILogger<ConteudoController> _logger;

        public ConteudoController(ILogger<ConteudoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}