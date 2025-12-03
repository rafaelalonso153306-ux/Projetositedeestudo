using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projetositedeestudo.Contexts;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class CursoController : Controller
    {
        BancoDoProjetoContext context = new BancoDoProjetoContext();


        public IActionResult Index()
        {
            var listaCursos = context.Cursos.ToList();

            ViewBag.ListaCursos = listaCursos;

            return View();
        }
    
    
        [Route("CursoDetalhes/")]
        public IActionResult CursoDetalhes(int id)
        {
           Curso curso = context.Cursos.FirstOrDefault(x => x.Id == id);

            ViewBag.Cursos = curso;

            return View();
        }

        [Route("CursoDetalhes")]
        public IActionResult CursoDetalhes(Curso curso)
        {
            context.Cursos.Update(curso);

            context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}