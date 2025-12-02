using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projetositedeestudo.Contexts;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
         BancoDoProjetoContext context = new BancoDoProjetoContext();

        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}