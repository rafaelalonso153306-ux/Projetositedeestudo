using Microsoft.AspNetCore.Mvc;
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
            List<Curso> listaCursos = context.Cursos.ToList();

            ViewBag.ListaCursos = listaCursos;

            return View();
        }
    
          // MOSTRA A TELA DE DETALHES
        [HttpGet("CursoDetalhes/{id}")]
        public IActionResult CursoDetalhes(int id)
        {
            var curso = context.Cursos.FirstOrDefault(x => x.Id == id);
            ViewBag.Cursos = curso;


            // Lista de materias do curso
            var conteudo = context.Conteudos.Where(x => x.CursoId == id).ToList();
            ViewBag.ListaConteudos = conteudo;

            return View();
        }

        // SALVA ALTERAÇÕES
        [HttpPost("CursoDetalhes")]
        public IActionResult CursoDetalhes(Curso curso)
        {
            context.Cursos.Update(curso);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}