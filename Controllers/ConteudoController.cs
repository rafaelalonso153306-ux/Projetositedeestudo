using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projetositedeestudo.Contexts;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class ConteudoController : Controller
    {
        BancoDoProjetoContext _context = new BancoDoProjetoContext();
        
        public IActionResult Index()
        {
            var lista = _context.Conteudos.ToList();
            var lista = _context.Conteudos.Include(c => c.Curso).ToList();

            ViewBag.ListaConteudos = lista;

            return View();
        }

    }
}
