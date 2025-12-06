using Microsoft.AspNetCore.Mvc;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class AtividadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}