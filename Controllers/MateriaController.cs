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
    public class MateriaController : Controller
    {
        private readonly ILogger<MateriaController> _logger;

        public MateriaController(ILogger<MateriaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}