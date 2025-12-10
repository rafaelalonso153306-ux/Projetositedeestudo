using Microsoft.AspNetCore.Mvc;
using Projetositedeestudo.Contexts;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        readonly BancoDoProjetoContext context = new BancoDoProjetoContext();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Autenticar")]
        public IActionResult Autenticar(string email, string senha)
        {
            // Buscar o usuário no banco
            var usuario = context.Usuarios.FirstOrDefault(
                u => u.Email == email && u.Senha == senha
            );

            if (usuario == null)
            {
                ViewBag.Erro = "E-mail ou senha inválidos";
                return View("Index");
            }

            // Salva o usuário na sessão
            HttpContext.Session.SetString("UsuarioNome", usuario.Nome);
            HttpContext.Session.SetInt32("UsuarioId", usuario.Id);

            return RedirectToAction("Index", "Home");
        }

        [Route("Sair")]
        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
