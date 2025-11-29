
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projetositedeestudo.Contexts;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class ConteudoController : Controller
    {
        BancoDoProjetoContext _context = new BancoDoProjetoContext();
        
        public IActionResult Index()
        {
            var lista = _context.Conteudos.Include(c => c.Curso).ToList();

            ViewBag.ListaConteudos = lista;

            return View();
        }

    }
}
