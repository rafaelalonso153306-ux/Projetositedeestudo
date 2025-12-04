using Microsoft.AspNetCore.Mvc;
using Projetositedeestudo.Contexts;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class MateriaUsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}