using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projetositedeestudo.Contexts;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class ConteudoController : Controller
    {
        readonly BancoDoProjetoContext context = new BancoDoProjetoContext();

        public IActionResult Index()
        {
            // Lista final, com include do Curso
            var lista = context.Conteudos
                               .Include(c => c.Curso)
                               .ToList();

            ViewBag.ListaConteudos = lista;

            return View();
        }
    }
}
