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
        BancoDoProjetoContext context = new BancoDoProjetoContext();

        public IActionResult Index()
        {
            //forma de listar todos os itens da tabela de (Usuario)
            var listaUsuarios = context.Usuarios.ToList();
            // passar a tela 
            ViewBag.listaUsuarios = listaUsuarios;
            return View();
        }
        
        [Route("Cadastrar")]
        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                //armazenar a equipe no banco de dados
                context.Add(usuario);

                // // Registrar as alterações no banco de dados  
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return RedirectToAction("Index");
        }
    }
}