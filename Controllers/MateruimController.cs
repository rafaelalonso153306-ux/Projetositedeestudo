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
    public class MateruimController : Controller
    {
        private readonly ILogger<MateruimController> _logger;

        public MateruimController(ILogger<MateruimController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}