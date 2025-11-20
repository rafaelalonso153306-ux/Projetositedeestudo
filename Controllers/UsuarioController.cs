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
    public class UsuarioController : Controller
    {
        bancodoprojetoContext context = new bancodoprojetoContext();

        public IActionResult Index()
        {
            //forma de listar todos os itens da tabela de (Usuario)
            var listaUsuarios = context.Usuarios.ToList();
            // passar a tela 
            ViewBag.listaUsuarios = listaUsuarios;
            return View();
        }
        
        [Route("cadastrar")]
        public IActionResult CadastrarUsuarios(Usuario usuario)
        {
            //armazenar a equipe no banco de dados
            context.Add(usuario);

            // // Registrar as alterações no banco de dados  
            context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}