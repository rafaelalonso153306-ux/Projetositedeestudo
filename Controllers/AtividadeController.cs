using Microsoft.AspNetCore.Mvc;
using Projetositedeestudo.Contexts;

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
    }
}
