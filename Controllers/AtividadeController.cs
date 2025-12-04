using Microsoft.AspNetCore.Mvc;
using Projetositedeestudo.Contexts;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class AtividadeController : Controller
    {
        private readonly ILogger<AtividadeController> _logger;

        public AtividadeController(ILogger<AtividadeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}