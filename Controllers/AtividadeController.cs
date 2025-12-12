using Microsoft.AspNetCore.Mvc;
using Projetositedeestudo.Contexts;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class AtividadeController : Controller
    {
        BancoDoProjetoContext context = new BancoDoProjetoContext();

        [Route("/atividade/conteudo/{idConteudo}")]
        public IActionResult Index(int idConteudo)
        {
            var lista = context.Atividades.Where(x => x.ConteudoId == idConteudo).ToList();

            ViewBag.ListaAtividades = lista;

            return View();
        }

        [HttpPost("/Atividade/Vincular")]
        public IActionResult Vincular([FromBody] string atividade)
        {
            AtividadesUsuario atv = new()
            {
                AtividadeId = int.Parse(atividade),
                UsuarioId = int.Parse(HttpContext.Session.GetString("UsuarioId"))
            };

            context.Add(atv);

            context.SaveChanges();

            return RedirectToAction("Index", "Conteudo");
        }
    }
}
