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

    }
}